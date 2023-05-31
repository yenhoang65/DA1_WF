using BLL;
using DAL.Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1_WF.In_hóa_đơn
{
    public partial class frmInHDB : Form
    {
        public frmInHDB()
        {
            InitializeComponent();
        }

        private DataTable hdb(string mahdb)
        {
            BLLHoaDonBan bllhdb = new BLLHoaDonBan();
            List<hoadonban> hdb = bllhdb.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHDB");
            dt.Columns.Add("NhanVienBH");
            dt.Columns.Add("TenKH");
            dt.Columns.Add("SDT");
            dt.Columns.Add("NgayBan");
            dt.Columns.Add("HTTT");
            foreach (var h in hdb)
            {
                if (h.mahdb == mahdb)
                {
                    DataRow r = dt.NewRow();
                    r["MaHDB"] = h.mahdb;
                    r["NhanVienBH"] = h.NhanVien.hoten;
                    r["TenKH"] = h.khachhang.hoten;
                    r["SDT"] = h.khachhang.sdt;
                    r["NgayBan"] = h.ngayBan;
                    r["HTTT"] = h.hinhthucthanhtoan;
                    dt.Rows.Add(r);
                    break;
                }
            }
            return dt;
        }

        private DataTable cthdb(string mahdb)
        {
            BLLChiTietHDB bllcthdb = new BLLChiTietHDB();
            List<chitiethdb> cthdb = bllcthdb.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("TenSanPham");
            dt.Columns.Add("GiaBan", typeof(Double));
            dt.Columns.Add("SoLuong", typeof(Double));
            dt.Columns.Add("ThanhTien", typeof(Double));
            foreach (var h in cthdb)
            {
                if (h.mahdb == mahdb)
                {
                    double tt = (Double)(h.soluong * h.sanpham.giaban).Value;
                    DataRow r = dt.NewRow();
                    r["TenSanPham"] = h.sanpham.tensp;
                    r["GiaBan"] = (Double)h.sanpham.giaban;
                    r["SoLuong"] = (Double)h.soluong;
                    r["ThanhTien"] = tt;
                    dt.Rows.Add(r);

                }
            }
            return dt;
        }

        private void frmInHDB_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA1_WF.InHD.Report1.rdlc";

            ReportDataSource r1 = new ReportDataSource();
            r1.Name = "DataSet1";
            r1.Value = cthdb(frmHDB.hdb.mahdb);
            this.reportViewer1.LocalReport.DataSources.Add(r1);

            ReportDataSource r2 = new ReportDataSource();
            r2.Name = "DataSet2";
            r2.Value = hdb(frmHDB.hdb.mahdb);
            this.reportViewer1.LocalReport.DataSources.Add(r2);
            this.reportViewer1.RefreshReport();
        }
    }
}
