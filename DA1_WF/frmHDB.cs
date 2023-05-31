using BLL;
using DA1_WF.In_hóa_đơn;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1_WF
{
    public partial class frmHDB : Form
    {
        private Form active;
        BLLHoaDonBan bllhdb = new BLLHoaDonBan();
        BLLKhachHang bllkh = new BLLKhachHang();        
        public static hoadonban hdb = new hoadonban();

        public frmHDB()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void LamMoi()
        {
            BLLHoaDonBan hdb = new BLLHoaDonBan();
            dtNgayBan.Value = DateTime.Now;
            AutoCompleteStringCollection suggest = new AutoCompleteStringCollection();
            txtSdtKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSdtKH.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach(var i in bllkh.getAll())
            {
                suggest.Add(i.sdt.ToString());
            }

            txtSdtKH.AutoCompleteCustomSource = suggest;
            cbbHTTT.Items.AddRange(new string[] { "Trả tiền mặt", "Banking" });
            //loadcbbSDT();
            load(dgHDB, tb(hdb.getAll()));
            dtNgayBan.Value = DateTime.Now;
        }
        private void btnLamMoiHDB_Click(object sender, EventArgs e)
        {
            txtMaHDB.Text = "";
            txtMaNVKH.Text = "";
            dtNgayBan.Value = DateTime.Now;
            //cbbSdtKH.Items.Clear();
            txtSdtKH.Text = "";
            txtTenKH.Text = "";
            cbbHTTT.Items.Clear();
            txtMaHDB.Focus();
            
            LamMoi();
        }

        private void btndskh_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void dgHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDB.Text = dgHDB.CurrentRow.Cells["Mã hóa đơn"].Value.ToString();

            if (txtMaHDB.Text != "")
            {
                txtMaNVKH.Text = dgHDB.CurrentRow.Cells["Mã nhân viên"].Value.ToString();
                txtSdtKH.Text = dgHDB.CurrentRow.Cells["Số điện thoại"].Value.ToString();
                dtNgayBan.Value = DateTime.Parse(dgHDB.CurrentRow.Cells["Ngày bán"].Value.ToString());
                cbbHTTT.SelectedItem = dgHDB.CurrentRow.Cells["Hình thức thanh toán"].Value.ToString();
                foreach (var x in bllhdb.getAll())
                {
                    if (x.mahdb == txtMaHDB.Text)
                    {
                        hdb = x;
                        break;
                    }
                }
            }
        }

        private void loadcbbSDT()
        {
            //List<khachhang> list = bllkh.getAll();
            //foreach(var i in list)
            //{
            //    cbbSdtKH.Items.Add(i.sdt);
            //}
        }
        private void frmHDB_Load(object sender, EventArgs e)
        {
            //dtNgayBan.Value = DateTime.Now;
            //AutoCompleteStringCollection suggest = new AutoCompleteStringCollection();
            //cbbSdtKH.AutoCompleteMode = AutoCompleteMode.None;
            //cbbSdtKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //cbbHTTT.Items.AddRange(new string[] { "Trả tiền mặt", "Banking" });
            //loadcbbSDT();
            LamMoi();
            //load(dgHDB, tb());
        }

        private DataGridView load(DataGridView dg, DataTable tb)
        {
            dg.DataSource = tb;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
            dg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return dg;
        }

        private DataTable tb(List<hoadonban> hdb)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Nhân viên bán hàng");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Ngày bán");
            dt.Columns.Add("Hình thức thanh toán");
            foreach (hoadonban h in hdb)
            {
                DataRow row = dt.NewRow();
                row["Mã hóa đơn"] = h.mahdb;
                row["Mã nhân viên"] = h.maNV;
                row["Ngày bán"] = h.ngayBan;
                row["Hình thức thanh toán"] = h.hinhthucthanhtoan;
                row["Nhân viên bán hàng"] = h.NhanVien != null ? h.NhanVien.hoten : string.Empty;
                //row["Nhân viên bán hàng"] = h.NhanVien.hoten;
                row["Số điện thoại"] = h.khachhang.sdt;
                //row["Tên khách hàng"] = h.khachhang.hoten;
                //row["Số điện thoại"] = h.khachhang != null ? h.khachhang.sdt : string.Empty;
                row["Tên khách hàng"] = h.khachhang != null ? h.khachhang.hoten : string.Empty;
                dt.Rows.Add(row);
            }
            return dt;
        } 

        private void HienThiCTHD(string ma, object sender)
        {
            BLLHoaDonBan bllhdb = new BLLHoaDonBan();
            string mahdb = ma;
            foreach (var i in bllhdb.getAll())
            {
                if (mahdb == i.mahdb)
                {
                    hdb = i;
                    break;
                }
            }
            frmCTHDB frm = new frmCTHDB(this);
            //OpenForm(frm, sender);
            frm.ShowDialog();
        }

        private bool KiemTraDuLieu(string sdt, string httt, string tenkh, DateTime ngayban, bool kt)
        {
            int flag = 0;
            if (sdt.Length == 9)
            {
                errorProvider1.Clear();
            }
            else
            {
                flag = 1;
                errorProvider1.SetError(txtSdtKH, "Số điện thoại phải chứa 10 ký tự số");
            }
            if (ngayban <= DateTime.Now)
            {
                errorProvider2.Clear();
            }
            else
            {
                flag = 1;
                errorProvider2.SetError(dtNgayBan, "Ngày bán không được lớn hơn ngày hiện tại");
            }
            if (httt != "")
            {
                errorProvider3.Clear();
            }
            else
            {
                flag = 1;
                errorProvider3.SetError(cbbHTTT, "Hình thức thanh toán chưa được chọn");
            }
            if (tenkh.Trim() != "")
            {
                errorProvider4.Clear();
            }
            else
            {
                flag = 1;
                errorProvider4.SetError(txtTenKH, "Khách hàng không tồn tại vui lòng thêm khách hàng mới");
            }
            if (flag == 0)
                kt = true;
            else
                kt = false;
            return kt;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            hoadonban hdb = new hoadonban();
            List<khachhang> kh = bllkh.getAll();
            hdb.mahdb = txtMaHDB.Text;
            hdb.maNV = txtMaNVKH.Text;
            foreach (var i in kh)
            {
                //if (i.sdt.ToString() == (cbbSdtKH.SelectedItem + "").Trim())
                if (i.sdt.ToString() == txtSdtKH.Text)
                {
                    hdb.maKH = i.maKH;
                    break;
                }
            }
            hdb.hinhthucthanhtoan = cbbHTTT.SelectedItem + "";
            hdb.ngayBan = dtNgayBan.Value;
            bool b = false;
            b = KiemTraDuLieu(txtSdtKH.Text + "", cbbHTTT.SelectedItem + "", txtTenKH.Text + "", dtNgayBan.Value, b);
            if (b)
            {
                bllhdb.insert(hdb);
                MessageBox.Show("Thêm thành công");
                HienThiCTHD(txtMaHDB.Text, sender);
                LamMoi();
            }
        }

        private void btnSuaHDB_Click(object sender, EventArgs e)
        {
            hoadonban hdb = new hoadonban();
            List<khachhang> kh = bllkh.getAll();
            hdb.mahdb = txtMaHDB.Text;
            hdb.maNV = txtMaNVKH.Text;
            foreach (var i in kh)
            {
                //if (i.sdt.ToString() == (cbbSdtKH.SelectedItem + "").Trim())
                if (i.sdt.ToString() == txtSdtKH.Text)
                {
                    hdb.maKH = i.maKH;
                    break;
                }
            }
            hdb.hinhthucthanhtoan = cbbHTTT.SelectedItem + "";
            hdb.ngayBan = dtNgayBan.Value;
            bool b = false;
            b = KiemTraDuLieu(txtSdtKH.Text + "", cbbHTTT.SelectedItem + "", txtTenKH.Text + "", dtNgayBan.Value, b);
            if (b)
            {
                bllhdb.edit(hdb);
                MessageBox.Show("Sửa thành công");
                LamMoi();
            }
        }

        private void btnXoaHDB_Click(object sender, EventArgs e)
        {
            bllhdb.delete(txtMaHDB.Text);
            MessageBox.Show("Xóa thành công");
            LamMoi();
        }

        private void txtSdtKH_TextChanged(object sender, EventArgs e)
        {
            List<khachhang> list = bllkh.getAll();
            txtTenKH.Text = "";
            foreach (var i in list)
            {
                if (txtSdtKH.Text == i.sdt.ToString())
                {
                    txtTenKH.Text = i.hoten;
                    break;
                }
            }
            
        }

        private void dgHDB_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahd = txtMaHDB.Text = dgHDB.CurrentRow.Cells["Mã hóa đơn"].Value.ToString();
            if (mahd != "")
            {
                HienThiCTHD(mahd, sender);
            }
        }

        private void btnTimKiemHDB_Click(object sender, EventArgs e)
        {
            List<SearchHDB_Result> listsp = bllhdb.SearchHDB(dtTuNgay.Value, dtDenNgay.Value, int.Parse(txtTkHDBbSDT.Text));
            List<hoadonban> listhdb = bllhdb.getAll();
            List<hoadonban> list = new List<hoadonban>();
            foreach (var i in listsp)
            {
                foreach (var j in listhdb)
                {
                    if (i.mahdb == j.mahdb)
                    {
                        list.Add(j);
                    }
                }
            }
            load(dgHDB, tb(list));
        }

        private void btnInHDB_Click(object sender, EventArgs e)
        {
            frmInHDB frm =new frmInHDB();
            frm.ShowDialog();
        }

        private void txtMaHDB_TextChanged(object sender, EventArgs e)
        {
            //List<hoadonban> list = bllhdb.getAll();
            //bool check = false;
            //btnThemHD.Enabled = true;
            //btnSuaHDB.Enabled = false;
            //btnXoaHDB.Enabled = false;
            //btnInHDB.Enabled = false;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (txtMaHDB.Text == list[i].mahdb)
            //    {
            //        check = true;
            //        btnThemHD.Enabled = false;
            //        btnSuaHDB.Enabled = true;
            //        btnXoaHDB.Enabled = true;
            //        btnInHDB.Enabled = true;
            //        break;
            //    }
            //}
            //if (check == false)
            //{
            //    dtNgayBan.Value = DateTime.Now;
            //}

        }
    }
}
