using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entities;

namespace DA1_WF
{
    internal static class Program
    {
        public static NhanVien nv;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            Application.Run(new frmLogin());
            //Application.Run(new frmNhanVien());
            //Application.Run(new frmChucVu());
            //Application.Run(new frmSanPham());
            //Application.Run(new frmKhachHang());
            //Application.Run(new frmNCC());
            //Application.Run(new frmCTHDN());
            //Application.Run(new frmHDN());
            //Application.Run(new frmHDB());
            //Application.Run(new frmThongKe());
        }
    }
}
