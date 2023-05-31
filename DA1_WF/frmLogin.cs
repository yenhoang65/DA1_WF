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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DA1_WF
{
    public partial class frmLogin : Form
    {
        NhanVien nv = new NhanVien();
        BLLLogin blllogin = new BLLLogin();
        public frmLogin()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //NhanVien nv = new NhanVien();
            Program.nv = blllogin.getUser(txtUserName.Text, txtPass.Text);
            if (Program.nv != null)
            {
                frmMain f = new frmMain();
                f.Show();
                this.Hide();
            }
            else
            {
                txtUserName.Focus();
                txtUserName.SelectAll();
                errorProvider1.SetError(txtUserName, "User name or password is invalid");
            }

            
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPass.PasswordChar = (char)0;
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
