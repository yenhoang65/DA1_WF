using BLL;
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
    public partial class frmCTHDB : Form
    {
        frmHDB frmHDB;
        public frmCTHDB(frmHDB frmHDB)
        {
            InitializeComponent();
            this.frmHDB = frmHDB;
        }

        BLLChiTietHDB bllCthd = new BLLChiTietHDB();
        BLLSanPham bllsp = new BLLSanPham();

        private void frmCTHDB_Load(object sender, EventArgs e)
        {
            txtMaHDB.Text = frmHDB.hdb.mahdb;
            txtNVBanHang.Text = frmHDB.hdb.NhanVien.hoten;
            txtTenKHCTHDB.Text = frmHDB.hdb.khachhang.hoten;
            txtSdtKH.Text = frmHDB.hdb.khachhang.sdt.ToString();
            txtHTTT.Text = frmHDB.hdb.hinhthucthanhtoan;
            txtNgayBan.Text = frmHDB.hdb.ngayBan.Value.ToString("dd/MM/yyyy");
            Data();
        }

        private void Data()
        {
            BLLChiTietHDB cthdb = new BLLChiTietHDB();
            cbbSanPhamCTHDB.SelectedIndex = -1;
            cbbSanPhamCTHDB.Items.Clear();
            txtSoLuongCTHDB.Text = "0";
            int sum = 0;
            foreach(var h in cthdb.getAll())
            {
                if (h.mahdb == frmHDB.hdb.mahdb) 
                {
                    int thanhtien = (h.soluong * h.sanpham.giaban).Value;
                    sum = sum + thanhtien;
                }
            }

            foreach(var sp in bllsp.getAll())
            {
                cbbSanPhamCTHDB.Items.Add(sp.tensp);
            }
            txtTongTien.Text = sum + "";
            load(dgCTHDB, tb(cthdb.getAll(), frmHDB.hdb.mahdb));
        }

        private DataGridView load(DataGridView dg, DataTable tb)
        {
            dg.DataSource = tb;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return dg;
        }

        private DataTable tb(List<chitiethdb> list, string mahdb)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Sản phẩm");
            dt.Columns.Add("Gía bán");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Thành tiền");
            foreach(var h in list)
            {
                if (h.mahdb == mahdb)
                {
                    DataRow row = dt.NewRow();
                    row["Sản phẩm"] = h.sanpham.tensp;
                    row["Gía bán"] = h.sanpham.giaban;
                    row["Số lượng"] = h.soluong;
                    row["Thành tiền"] = h.sanpham.giaban * h.soluong;
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }

        private void dgCTHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbSanPhamCTHDB.SelectedItem = dgCTHDB.CurrentRow.Cells["Sản phẩm"].Value.ToString();
            txtSoLuongCTHDB.Text= dgCTHDB.CurrentRow.Cells["Số lượng"].Value.ToString();
        }

        private void cbbSanPhamCTHDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLLChiTietHDB cthd = new BLLChiTietHDB();
            List<chitiethdb>list= cthd.getAll();
            bool thuoc = false;
            btnCapNhatCTHDB.Enabled =true;
            btnSuaCTHDB.Enabled = false;
            btnXoaCTHDB.Enabled = false;
            for (int i = 0; i < list.Count; i++)
            {
                if ((cbbSanPhamCTHDB.SelectedItem + "" == list[i].sanpham.tensp) && (list[i].mahdb == frmHDB.hdb.mahdb))
                {
                    thuoc = true;
                    txtSoLuongCTHDB.Text = list[i].soluong + "";
                    btnCapNhatCTHDB.Enabled=true;
                    btnSuaCTHDB.Enabled = true;
                    btnXoaCTHDB.Enabled = true;
                    break;
                }
            }

            if (thuoc == false)
            {
                txtSoLuongCTHDB.Text = "0";
            }
        }

        private void btnCapNhatCTHDB_Click(object sender, EventArgs e)
        {
            int soluong = 0;
            chitiethdb chitiethdb = new chitiethdb();
            chitiethdb.mahdb=frmHDB.hdb.mahdb;
            foreach(var h in bllsp.getAll())
            {
                if (h.tensp == cbbSanPhamCTHDB.SelectedItem + "")
                {
                    chitiethdb.maSP = h.masp;
                    soluong = h.soluong.Value;
                    break;
                }
            }
            chitiethdb.soluong = int.Parse(txtSoLuongCTHDB.Text);
            if (int.Parse(txtSoLuongCTHDB.Text) > soluong)
            {
                txtSoLuongCTHDB.Focus();
                txtSoLuongCTHDB.SelectAll();
                errorProvider1.SetError(txtSoLuongCTHDB, "Số lượng trong kho chỉ còn " + soluong + " sản phẩm");
            }

            else if (int.Parse(txtSoLuongCTHDB.Text) == 0)
            {
                txtSoLuongCTHDB.Focus();
                txtSoLuongCTHDB.SelectAll();
                errorProvider1.SetError(txtSoLuongCTHDB, "Số lượng phải lớn hơn 0");
            }
            else
            {
                bllCthd.insert(chitiethdb);
                MessageBox.Show("Thêm thành công!");
                errorProvider1.Clear();
                Data();
            }
        }

        private void btnSuaCTHDB_Click(object sender, EventArgs e)
        {
            int soluong = 0;
            chitiethdb chitiethdb = new chitiethdb();
            chitiethdb.mahdb = frmHDB.hdb.mahdb;
            foreach (var h in bllsp.getAll())
            {
                if (h.tensp == cbbSanPhamCTHDB.SelectedItem + "")
                {
                    chitiethdb.maSP = h.masp;
                    soluong = h.soluong.Value;
                    break;
                }
            }
            chitiethdb.soluong = int.Parse(txtSoLuongCTHDB.Text);
            if (int.Parse(txtSoLuongCTHDB.Text) > soluong)
            {
                txtSoLuongCTHDB.Focus();
                txtSoLuongCTHDB.SelectAll();
                errorProvider1.SetError(txtSoLuongCTHDB, "Số lượng trong kho chỉ còn " + soluong + " sản phẩm");
            }

            else if (int.Parse(txtSoLuongCTHDB.Text) == 0)
            {
                txtSoLuongCTHDB.Focus();
                txtSoLuongCTHDB.SelectAll();
                errorProvider1.SetError(txtSoLuongCTHDB, "Số lượng phải lớn hơn 0");
            }
            else
            {
                bllCthd.edit(chitiethdb);
                MessageBox.Show("Sửa thành công!");
                errorProvider1.Clear();
                Data();
            }
        }

        private void btnLamMoiCTHDB_Click(object sender, EventArgs e)
        {
            Data();
        }

        private void btnXoaCTHDB_Click(object sender, EventArgs e)
        {
            string masp = "";
            foreach(var h in bllsp.getAll())
            {
                if (h.tensp == cbbSanPhamCTHDB.SelectedItem + "")
                {
                    masp = h.masp;
                    break;
                }
            }
            bllCthd.delete(txtMaHDB.Text, masp);
            MessageBox.Show("Xóa thành công");
        }
    }
}
