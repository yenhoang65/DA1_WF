using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.Entities;

namespace DA1_WF
{
    public partial class frmNhanVien : Form
    {
        BLLNhanVien bllnv = new BLLNhanVien();
        BLLChucVu bllcv = new BLLChucVu();
        public frmNhanVien()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void New()
        {
            BLLNhanVien nv = new BLLNhanVien();
            load(dgNV, tb(nv.getAll()));
        }

        private bool KiemTraDuLieu(string tennv, string sdt, string chucvu, DateTime ngaysinh, bool kt)
        {
            int flag = 0;
            if (tennv.Trim() != "")
            {
                errorProvider1.Clear();
            }
            else
            {
                flag = 1;
                errorProvider1.SetError(txtTenNV, "Tên nhân viên không để trống");
            }
            if (sdt.Trim().Length == 9)
            {
                errorProvider2.Clear();

            }
            else
            {
                flag = 1;
                errorProvider2.SetError(txtsdtNV, "Số điện thoại không được để trống và phải có 10 ký tự");
            }

            if (chucvu.Trim() != "")
            {
                errorProvider4.Clear();

            }
            else
            {
                flag = 1;
                errorProvider4.SetError(cbbChucVu, "Chưa chọn chức vụ");
            }
            if (DateTime.Now.Year - ngaysinh.Year >= 18)
            {
                errorProvider3.Clear();

            }
            else
            {
                flag = 1;
                errorProvider3.SetError(dtpNgaySinh, "Nhân viên chưa đủ 18 tuổi ");

            }

            if (flag == 0)
                kt = true;
            else
                kt = false;
            return kt;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            List<ChucVu> list = bllcv.getAll();
            nv.maNV = txtmaNV.Text;
            nv.hoten = txtTenNV.Text;
            nv.namsinh = dtpNgaySinh.Value;
            if (radNam.Checked)
            {
                nv.gioitinh = "Nam";
            }
            else if (radNu.Checked)
            {
                nv.gioitinh = "Nữ";
            }
            nv.sdt = int.Parse(txtsdtNV.Text);
            foreach (var cv in list)
            {
                if (cv.tenCV == (cbbChucVu.SelectedItem + "").Trim())
                {
                    nv.maCV = cv.maCV;
                    break;
                }
            }
            nv.pw = txtpw.Text;

            bool b = false;
            b = KiemTraDuLieu(txtTenNV.Text + "", txtsdtNV.Text + "", cbbChucVu.SelectedItem + "", dtpNgaySinh.Value, b);
            if (b == true)
            {
                bllnv.insert(nv);
                MessageBox.Show("Thêm thành công");
                //load(dgNV, tb());
                New();

            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            
            loadcbb();
            New();
        }

        private void loadcbb()
        {
            List<ChucVu> list = bllcv.getAll();
            foreach(var i in list)
            {
                cbbChucVu.Items.Add(i.tenCV);
            }
        }
        private DataGridView load(DataGridView dg, DataTable tb)
        {
            dg.DataSource = tb;
            dgNV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgNV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgNV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgNV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgNV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgNV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgNV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return dg;
        }

        private DataTable tb(List<NhanVien> list)
        {
            //List<NhanVien> list = bllnv.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên nhân viên");
            dt.Columns.Add("Năm sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Chức vụ");
            dt.Columns.Add("Mật khẩu đăng nhập");
            foreach (NhanVien n in list)
            {
                DataRow row = dt.NewRow();
                row["Mã nhân viên"] = n.maNV;
                row["Tên nhân viên"] = n.hoten;
                row["Năm sinh"] = n.namsinh;
                row["Giới tính"] = n.gioitinh;
                row["Số điện thoại"] = n.sdt;
                row["Chức vụ"] = n.ChucVu.tenCV;
                row["Mật khẩu đăng nhập"] = n.pw;
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn đóng Form không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void dgNV_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            txtmaNV.Text = dgNV.CurrentRow.Cells["Mã nhân viên"].Value.ToString();
            if (txtmaNV.Text != "")
            {
                txtTenNV.Text = dgNV.CurrentRow.Cells["Tên nhân viên"].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgNV.CurrentRow.Cells["Năm sinh"].Value.ToString());
                cbbChucVu.SelectedItem = dgNV.CurrentRow.Cells["Chức vụ"].Value.ToString();
                if (dgNV.CurrentRow.Cells["Giới tính"].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                else if (dgNV.CurrentRow.Cells["Giới tính"].Value.ToString() == "Nữ")
                {
                    radNu.Checked = true;
                }
                txtsdtNV.Text = dgNV.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            }
            txtpw.Text = dgNV.CurrentRow.Cells["Mật khẩu đăng nhập"].Value.ToString();
        }

        private void btnQLCV_Click(object sender, EventArgs e)
        {
            frmChucVu cv = new frmChucVu();
            cv.ShowDialog();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            List<ChucVu> list = bllcv.getAll();
            nv.maNV = txtmaNV.Text;
            nv.hoten = txtTenNV.Text;
            nv.namsinh = dtpNgaySinh.Value;
            if (radNam.Checked)
            {
                nv.gioitinh = "Nam";
            }
            else if (radNu.Checked)
            {
                nv.gioitinh = "Nữ";
            }
            nv.sdt = int.Parse(txtsdtNV.Text);
            foreach (var cv in list)
            {
                if (cv.tenCV == (cbbChucVu.SelectedItem + "").Trim())
                {
                    nv.maCV = cv.maCV;
                    break;
                }
            }
            nv.pw = txtpw.Text;

            bool b = false;
            b = KiemTraDuLieu(txtTenNV.Text + "", txtsdtNV.Text + "", cbbChucVu.SelectedItem + "", dtpNgaySinh.Value, b);
            if (b == true)
            {
                bllnv.edit(nv);
                MessageBox.Show("Sửa thành công");
                New();

            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            bllnv.delete(txtmaNV.Text);
            MessageBox.Show("Xóa thành công");
            New();
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            txtmaNV.Text = "";
            txtTenNV.Text = "";
            txtsdtNV.Text = "";
            txtpw.Text = "";
            cbbChucVu.Items.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            radNam.Checked = false;
            radNu.Checked = false;
            txttkManv.Text = "";
            txtmaNV.Focus();
            New();
            loadcbb();
        }

        private void btnTkNV_Click(object sender, EventArgs e)
        {
            List<SP_SearchNV_Result> search = bllnv.Search(txttkManv.Text);
            List<NhanVien> lnv = bllnv.getAll();
            List<NhanVien> listnv = new List<NhanVien>();
            foreach (var i in search)
            {
                foreach (var j in lnv)
                {
                    if (i.maNV == j.maNV)
                    {
                        listnv.Add(j);
                    }
                }
            }
            load(dgNV, tb(listnv));
        }
    }
}
