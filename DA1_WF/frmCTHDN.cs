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
    public partial class frmCTHDN : Form
    {
        frmHDN frmHDN;
        public frmCTHDN()
        {
            InitializeComponent();
            this.frmHDN = frmHDN;
        }

        BLLChiTietHDN bllCTHDN = new BLLChiTietHDN();
        BLLSanPham bllsp = new BLLSanPham();

        private void frmCTHDN_Load(object sender, EventArgs e)
        {
            txtMaHDnhaphang.Text = frmHDN.hdn.mahdn;
            txtTenNV.Text = frmHDN.hdn.NhanVien.hoten;            
            txtNCC.Text = frmHDN.hdn.ncc.tenncc;
            txtDiaChi.Text = frmHDN.hdn.ncc.diachi;
            txtSdt.Text = frmHDN.hdn.ncc.sdt.ToString();
            txtNgayNhap.Text = frmHDN.hdn.ngayNhap.Value.ToString("dd/MM/yyyy");
            LamMoi();
        }

        private void LamMoi()
        {
            BLLChiTietHDN cthd = new BLLChiTietHDN();
            cbbSanPhamCTHDN.SelectedIndex = -1;
            cbbSanPhamCTHDN.Items.Clear();
            txtSoLuong.Text = "0";
            txtGiaNhap.Text = "0";
            int sum = 0;
            foreach (var x in cthd.getAll())
            {
                if (x.mahdn == frmHDN.hdn.mahdn)
                {
                    int thanhtien = (x.soluong * x.gianhap).Value;
                    sum += thanhtien;
                }
            }
            foreach (var x in bllsp.getAll())
            {
                cbbSanPhamCTHDN.Items.Add(x.tensp);
            }
            txtTongTienCTHDN.Text = sum.ToString();
            LoadData(dgCTHDN, dt(cthd.getAll(), frmHDN.hdn.mahdn));
        }
        private DataGridView LoadData(DataGridView o, DataTable x)
        {
            o.DataSource = x;
            o.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            o.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            o.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            o.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return o;
        }
        private DataTable dt(List<chitiethdn> list, string mahd)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Sản phẩm");
            dt.Columns.Add("Giá nhập");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Thành tiền");
            foreach (var x in list)
            {
                if (x.mahdn == mahd)
                {
                    DataRow row = dt.NewRow();
                    row["Sản phẩm"] = x.sanpham.tensp;
                    row["Giá nhập"] = x.gianhap;
                    row["Số lượng"] = x.soluong;
                    row["Thành tiền"] = x.gianhap * x.soluong;
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }

        private void dgCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbSanPhamCTHDN.SelectedItem = dgCTHDN.CurrentRow.Cells["Sản phẩm"].Value.ToString();
            txtGiaNhap.Text = dgCTHDN.CurrentRow.Cells["Giá nhập"].Value.ToString();
            txtSoLuong.Text = dgCTHDN.CurrentRow.Cells["Số lượng"].Value.ToString();
        }

        private bool KiemTraDuLieu(int gianhap, int soluong, bool kt)
        {
            int flag = 0;
            if (gianhap != 0)
            {
                errorProvider1.Clear();
            }
            else
            {
                flag = 1;
                errorProvider1.SetError(txtGiaNhap, "Giá nhập phải lớn hơn 0");

            }
            if (soluong != 0)
            {
                errorProvider2.Clear();
            }
            else
            {
                flag = 1;
                errorProvider2.SetError(txtSoLuong, "Số lượng phải lớn hơn 0");

            }
            if (flag == 0)
                kt = true;
            else
                kt = false;
            return kt;
        }

        private void btnCapNhatCTHDN_Click(object sender, EventArgs e)
        {
            chitiethdn cthd = new chitiethdn();
            cthd.mahdn = frmHDN.hdn.mahdn;
            foreach (var x in bllsp.getAll())
            {
                if (x.tensp == cbbSanPhamCTHDN.SelectedItem + "")
                {
                    cthd.maSP = x.masp;
                    break;
                }
            }
            cthd.gianhap = int.Parse(txtGiaNhap.Text);
            cthd.soluong = int.Parse(txtSoLuong.Text);
            bool b = false;
            b = KiemTraDuLieu(int.Parse(txtGiaNhap.Text), int.Parse(txtSoLuong.Text), b);
            if (b)
            {
                bllCTHDN.insert(cthd);
                MessageBox.Show("Thêm thành công!", "Thông báo");
                LamMoi();
            }
        }

        private void btnSuaCTHDN_Click(object sender, EventArgs e)
        {
            chitiethdn cthd = new chitiethdn();
            cthd.mahdn = frmHDN.hdn.mahdn;
            foreach (var x in bllsp.getAll())
            {
                if (x.tensp == cbbSanPhamCTHDN.SelectedItem + "")
                {
                    cthd.maSP = x.masp;
                    break;
                }
            }
            cthd.gianhap = int.Parse(txtGiaNhap.Text);
            cthd.soluong = int.Parse(txtSoLuong.Text);
            bllCTHDN.edit(cthd);
            MessageBox.Show("Thêm thành công!", "Thông báo");
            LamMoi();
        }

        private void btnXoaCTHDN_Click(object sender, EventArgs e)
        {
            string mamt = "";
            foreach (var x in bllsp.getAll())
            {
                if (x.tensp == cbbSanPhamCTHDN.SelectedItem + "")
                {
                    mamt = x.masp;
                    break;
                }
            }
            bllCTHDN.delete(txtMaHDnhaphang.Text, mamt);
            MessageBox.Show("Xóa thành công", "Thông báo");
            LamMoi();
        }

        private void cbbSanPhamCTHDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLLChiTietHDN bllCTHDN = new BLLChiTietHDN();
            List<chitiethdn> list = bllCTHDN.getAll();
            bool thuoc = false;
            for (int i = 0; i < list.Count; i++)
            {
                if ((cbbSanPhamCTHDN.SelectedItem + "" == list[i].sanpham.tensp) && list[i].mahdn == frmHDN.hdn.mahdn)
                {
                    thuoc = true;
                    txtSoLuong.Text = list[i].soluong + "";
                    txtGiaNhap.Text = list[i].gianhap + "";

                    break;
                }
            }
            if (thuoc == false)
            {
                txtSoLuong.Text = "0";
                txtGiaNhap.Text = "0";
            }
        }
    }
}
