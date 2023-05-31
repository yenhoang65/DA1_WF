using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entities;
using BLL;

namespace DA1_WF
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            switch (Program.nv.ChucVu.tenCV.Trim())
            {
                case "Nhân Viên":
                    btnQLNV.Enabled = false;
                    btnThongKe.Enabled = false;
                    break;
                case "Quản lý":
                    break;
            }
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.ShowDialog();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.ShowDialog();
        }

        private void btnQLHDB_Click(object sender, EventArgs e)
        {
            frmHDB frmHDB = new frmHDB();
            frmHDB.ShowDialog();
        }

        private void btnQLHDN_Click(object sender, EventArgs e)
        {
            frmHDN frmHDN = new frmHDN();
            frmHDN.ShowDialog();
        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
