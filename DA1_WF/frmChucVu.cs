using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using DAL.DAL;
using DAL.Entities;

namespace DA1_WF
{
    public partial class frmChucVu : Form
    {
        
        BLLChucVu bllcv = new BLLChucVu();
        public frmChucVu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private DataGridView LoadData(DataGridView dg, DataTable dt)
        {
            dg.DataSource = dt;
            dg.Columns[0].AutoSizeMode=DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return dg;
        }

        private DataTable dt()
        {
            List<ChucVu> list = bllcv.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã chức vụ");
            dt.Columns.Add("Tên chức vụ");
            dt.Columns.Add("Mô tả");
            int count = 0;
            foreach (ChucVu cv in list)
            {
                count += 1;
                DataRow row = dt.NewRow();
                row["Mã chức vụ"] = cv.maCV;
                row["Tên chức vụ"] = cv.tenCV;
                row["Mô tả"] = cv.mota;
                dt.Rows.Add(row);
            }
            return dt;
        }
        private void btnLamMoiHDB_Click(object sender, EventArgs e)
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
            txtMoTaChucVu.Text = "";
            txtMaChucVu.Focus();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            LoadData(dgChucVu, dt());
        }

        void loaddg()
        {
            
            dgChucVu.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            dgChucVu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgChucVu.Columns[0].HeaderText = "Mã CV";
            dgChucVu.Columns[1].HeaderText = "Tên CV";
            dgChucVu.Columns[2].HeaderText = "Mô tả";
            bllcv.getAll();
        }

        private void dgChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaChucVu.Text = dgChucVu[0, hang].Value.ToString();
            txtTenChucVu.Text=dgChucVu[1, hang].Value.ToString();
            txtMoTaChucVu.Text= dgChucVu[2, hang].Value.ToString();
        }

        private bool KiemTraDuLieu(string tencv, string mota, bool kt)
        {
            int flag = 0;
            if (tencv.Trim() != "")
            {
                errorProvider1.Clear();
            }
            else
            {
                flag = 1;
                errorProvider1.SetError(txtTenChucVu, "Tên chức vụ không được để trống");
            }
            if (mota.Trim() != "")
            {
                errorProvider2.Clear();
            }
            else
            {
                flag = 1;
                errorProvider2.SetError(txtMoTaChucVu, "Mô tả không được để trống");
            }
            if (flag == 0)
                kt = true;
            else
                kt = false;
            return kt;
        }

        private void btnThemChucvu_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();
            cv.maCV = txtMaChucVu.Text;
            cv.tenCV = txtTenChucVu.Text;
            cv.mota = txtMoTaChucVu.Text;
            bool b = false;
            b = KiemTraDuLieu(txtTenChucVu.Text + "", txtMaChucVu.Text + "", b);
            if (b)
            {
                bllcv.insert(cv);
                MessageBox.Show("Thêm thành công");
                LoadData(dgChucVu, dt());
            }
        }

        private void btnThoatChucvu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuaChucvu_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();
            cv.maCV = txtMaChucVu.Text;
            cv.tenCV = txtTenChucVu.Text;
            cv.mota = txtMoTaChucVu.Text;

            bool b = false;
            b = KiemTraDuLieu(txtTenChucVu.Text + "", txtMoTaChucVu.Text + "", b);
            if (b)
            {
                bllcv.edit(cv);
                MessageBox.Show("Sửa thành công");
                LoadData(dgChucVu, dt());
            }

        }

        private void btnXoaChucVu_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();
            bllcv.delete(txtMaChucVu.Text);
            LoadData(dgChucVu, dt());
        }

        private void frmChucVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.ShowDialog();
        }
    }
}
