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

namespace DA1_WF.InHD
{
    public partial class frmInHDN : Form
    {
        public frmInHDN()
        {
            InitializeComponent();
        }


        private DataTable dthdn(string ma)
        {
            BLLHoaDonNhap bllhdn = new BLLHoaDonNhap();
            List<hdn> hdn = bllhdn.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHDN");
            dt.Columns.Add("NhanVienNH");
            dt.Columns.Add("TenNCC");
            dt.Columns.Add("SDT");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("NgayNhap");
            foreach (var x in hdn)
            {
                if (x.mahdn == ma)
                {
                    DataRow row = dt.NewRow();
                    row["MaHDN"] = x.mahdn;
                    row["NhanVienNH"] = x.NhanVien.hoten;
                    row["TenNCC"] = x.ncc.tenncc;
                    row["SDT"] = x.ncc.sdt;
                    row["DiaChi"] = x.ncc.diachi;
                    row["NgayNhap"] = x.ngayNhap;
                    dt.Rows.Add(row);
                    break;
                }
            }
            return dt;
        }
        private DataTable dtcthdn(string ma)
        {
            BLLChiTietHDN bllct = new BLLChiTietHDN();
            List<chitiethdn> cthdn = bllct.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("SanPham");
            dt.Columns.Add("GiaNhap", typeof(Double));
            dt.Columns.Add("SoLuong", typeof(Double));
            dt.Columns.Add("ThanhTien", typeof(Double));
            foreach (var x in cthdn)
            {
                if (x.mahdn == ma)
                {
                    double tt = (Double)(x.soluong * x.gianhap).Value;
                    DataRow row = dt.NewRow();
                    row["SanPham"] = x.sanpham.tensp;
                    row["GiaNhap"] = x.gianhap;
                    row["SoLuong"] = x.soluong;
                    row["ThanhTien"] = tt;
                    dt.Rows.Add(row);
                }
            }
            return dt;

        }


        private void frmInHDN_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA1_WF.InHD.Report2.rdlc";

            ReportDataSource rds1 = new ReportDataSource();
            rds1.Name = "DataSet2";
            rds1.Value = dtcthdn(frmHDN.hdn.mahdn);
            ReportDataSource rds2 = new ReportDataSource();
            rds2.Name = "DataSet1";
            rds2.Value = dthdn(frmHDN.hdn.mahdn);
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
        }
    }
}
