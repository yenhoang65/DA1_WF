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
using DAL;
using BLL;
using DA1_WF.InHD;

namespace DA1_WF
{

    public partial class frmHDN : Form
    {
        BLLChiTietHDN bllcthdn = new BLLChiTietHDN();
        BLLHoaDonNhap bllhdn = new BLLHoaDonNhap();
        BLLNCC bllncc = new BLLNCC();
        public static hdn hdn = new hdn();
        public frmHDN()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        internal void Lammoi()
        {
            BLLHoaDonNhap bllhdn = new BLLHoaDonNhap();
            List<hdn> list = bllhdn.getAll();
            cbbNCC.SelectedIndex = -1;
            //cboNhaCungCap2.SelectedIndex = -1;
            cbbNCC.Items.Clear();
           // cboNhaCungCap2.Items.Clear();
            List<ncc> n = bllncc.getAll();
            foreach (ncc ncc in n)
            {
                //cboNhaCungCap2.Items.Add(nC.TenNCC);
                cbbNCC.Items.Add(ncc.tenncc);
                cbbTkbNCC.Items.Add(ncc.tenncc);
            }
            txtMaHDN.Text = "";
            txtMaNVHDN.Text = "";
            dtNgayNhap.Value = DateTime.Now;
            //txtMaHDN2.Text = "";
            //dtpTuNgay.Value = DateTime.Parse("4/30/1975");
            //dtpDenNgay.Value = DateTime.Now;
            //errorProvider1.Clear();
            //errorProvider2.Clear();
            LoadData(dgHDN, dt(list));
        }
        private DataGridView LoadData(DataGridView o, DataTable x)
        {
            o.DataSource = x;
            o.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            o.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            o.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            o.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            o.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return o;
        }
        private DataTable dt(List<hdn> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Nhân viên nhập hàng");
            dt.Columns.Add("Nhà cung cấp");
            dt.Columns.Add("Ngày Nhập");
            foreach (hdn h in list)
            {
                DataRow row = dt.NewRow();
                row["Mã hóa đơn"] = h.mahdn;
                row["Mã nhân viên"] = h.manv;
                row["Nhân viên nhập hàng"] = h.NhanVien.hoten;
                row["Nhà cung cấp"] = h.ncc.tenncc;
                row["Ngày nhập"] = h.ngayNhap;
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void frmHDN_Load(object sender, EventArgs e)
        {
            Lammoi();
        }

        private void btnDSNCC_Click(object sender, EventArgs e)
        {
            frmNCC frmNCC = new frmNCC();
            frmNCC.ShowDialog();
        }

        private void HienThiCTHD(string ma, object sender)
        {
            BLLHoaDonNhap bllhdn = new BLLHoaDonNhap();
            foreach (var i in bllhdn.getAll())
            {
                if (i.mahdn == ma)
                {
                    hdn = i;
                    break;
                }
            }
            frmCTHDN frm = new frmCTHDN();
            frm.ShowDialog();
        }

        private bool KiemTraDuLieu(string nhacc, DateTime ngaynhap, bool kt)
        {
            int flag = 0;
            if (nhacc != "")
            {
                errorProvider1.Clear();
            }
            else
            {
                flag = 1;
                errorProvider1.SetError(cbbNCC, "Chưa chọn nhà cung cấp");
            }
            if (ngaynhap <= DateTime.Now)
            {
                errorProvider2.Clear();
            }
            else
            {
                flag = 1;
                errorProvider2.SetError(dtNgayNhap, "Ngày nhập không thể lớn hơn ngày hiện tại");
            }
            if (flag == 0)
                kt = true;
            else
                kt = false;
            return kt;
        }

        private void btnThemHDN_Click(object sender, EventArgs e)
        {
            List<ncc> listncc = bllncc.getAll();
            hdn hd = new hdn();
            hd.mahdn = txtMaHDN.Text;
            hd.manv = txtMaNVHDN.Text;
            foreach (var x in listncc)
            {
                if (x.tenncc == cbbNCC.SelectedItem + "")
                {
                    hd.mancc = x.mancc;
                    break;
                }
            }
            hd.ngayNhap = dtNgayNhap.Value;
            //bllhdn.insert(hd);
            bool b = false;
            b = KiemTraDuLieu(cbbNCC.SelectedItem + "", dtNgayNhap.Value, b);
            if (b)
            {
                bllhdn.insert(hd);
                HienThiCTHD(txtMaHDN.Text, sender);
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo");
                Lammoi();

            }
        }

        private void btnSuaHDN_Click(object sender, EventArgs e)
        {
            List<ncc> listncc = bllncc.getAll();
            hdn hd = new hdn();
            hd.mahdn = txtMaHDN.Text;
            hd.manv = txtMaNVHDN.Text;
            foreach (var x in listncc)
            {
                if (x.tenncc == cbbNCC.SelectedItem + "")
                {
                    hd.mancc = x.mancc;
                    break;
                }
            }
            hd.ngayNhap = dtNgayNhap.Value;
            bllhdn.edit(hd);

            bool b = false;
            b = KiemTraDuLieu(cbbNCC.SelectedItem + "", dtNgayNhap.Value, b);
            if (b)
            {
                bllhdn.edit(hd);
                MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo");
                Lammoi();

            }
        }

        private void btnXoaHDN_Click(object sender, EventArgs e)
        {
            bllhdn.delete(txtMaHDN.Text);
            MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo");
            Lammoi();
        }

        private void dgHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDN.Text = dgHDN.CurrentRow.Cells["Mã hóa đơn"].Value.ToString();
            txtMaNVHDN.Text= dgHDN.CurrentRow.Cells["Mã nhân viên"].Value.ToString();
            if (txtMaHDN.Text != "")
            {
                cbbNCC.SelectedItem = dgHDN.CurrentRow.Cells["Nhà cung cấp"].Value.ToString();
                dtNgayNhap.Value = DateTime.Parse(dgHDN.CurrentRow.Cells["Ngày nhập"].Value.ToString());
                foreach (var x in bllhdn.getAll())
                {
                    if (x.mahdn == txtMaHDN.Text)
                    {
                        hdn = x;
                        break;
                    }
                }
            }
        }

        private void btnLamMoiHDN_Click(object sender, EventArgs e)
        {
            Lammoi();
        }

        private void btnTimKiemHDN_Click(object sender, EventArgs e)
        {
            List<SearchHDN_Result> listsp = bllhdn.SearchHDN(dtTuNgayHDN.Value, dtDenNgayHDN.Value, cbbTkbNCC.SelectedItem + "");
            List<hdn> listhdn = bllhdn.getAll();
            List<hdn> list = new List<hdn>();
            foreach (var i in listsp)
            {
                foreach (var j in listhdn)
                {
                    if (i.mahdn == j.mahdn)
                    {
                        list.Add(j);
                    }
                }
            }
            LoadData(dgHDN, dt(list));
        }

        private void btnInHDN_Click(object sender, EventArgs e)
        {
            frmInHDN frm = new frmInHDN();
            frm.ShowDialog();
        }

        private void dgHDN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahd = dgHDN.CurrentRow.Cells["Mã hóa đơn"].Value.ToString();
            if (mahd != "")
            {
                HienThiCTHD(mahd, sender);
            }
        }

        private void txtMaHDN_TextChanged(object sender, EventArgs e)
        {
            List<hdn> list = bllhdn.getAll();
            bool thuoc = false;
            btnThemHDN.Enabled = true;
            btnSuaHDN.Enabled = false;
            btnXoaHDN.Enabled = false;
            btnInHDN.Enabled = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (txtMaHDN.Text == list[i].mahdn)
                {
                    thuoc = true;
                    btnThemHDN.Enabled = false;
                    btnSuaHDN.Enabled = true;
                    btnXoaHDN.Enabled = true;
                    btnInHDN.Enabled = true;
                    break;
                }
            }
            if (thuoc == false)
            {
                dtNgayNhap.Value = DateTime.Now;
            }
        }
    }
}
