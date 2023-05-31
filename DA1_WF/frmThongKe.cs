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

namespace DA1_WF
{
    public partial class frmThongKe : Form
    {
        BLLThongKe blltk = new BLLThongKe();
        BLLSanPham bllsp = new BLLSanPham();
        public frmThongKe()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadData(dtTuNgay.Value, dtDenNgay.Value);
        }

        private DataTable slsp()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm");
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Xuất xứ");
            dt.Columns.Add("Số lượng");
            foreach (var x in bllsp.getAll())
            {
                if (x.soluong <= 50)
                {
                    DataRow row = dt.NewRow();
                    row["Mã sản phẩm"] = x.masp;
                    row["Tên sản phẩm"] = x.tensp;
                    row["Xuất xứ"] = x.xuatxu;
                    row["Số lượng"] = x.soluong;
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }

        private DataTable dt(DateTime tungay, DateTime denngay)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ngày bán");
            dt.Columns.Add("Doanh thu");
            dt.Columns.Add("Lợi nhuận");
            foreach (var x in blltk.TKDTLN(tungay, denngay))
            {
                DataRow row = dt.NewRow();
                row["Ngày bán"] = x.NgayBan.Value.ToString("dd/MM");
                row["Doanh thu"] = x.DoanhThu;
                row["Lợi nhuận"] = x.LoiNhuan;
                dt.Rows.Add(row);
            }
            return dt;
        }


        private void LoadData(DateTime tungay, DateTime denngay)
        {
            label1.Text = blltk.DoanhThu(tungay, denngay) + " đ";
            label2.Text = blltk.LoiNhuan(tungay, denngay) + " đ";
            label3.Text = blltk.SoKhachHang(tungay, denngay) + "";
            label4.Text = blltk.SoSanPham(tungay, denngay) + "";
            chart1.DataSource = dt(tungay, denngay);
            chart1.Series[0].XValueMember = "Ngày bán";
            chart1.Series[0].YValueMembers = "Doanh thu";

            chart1.Series[1].XValueMember = "Ngày bán";
            chart1.Series[1].YValueMembers = "Lợi nhuận";

            chart1.DataBind();

            dgSanPhamSapHet.DataSource = slsp();
            dgSanPhamSapHet.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgSanPhamSapHet.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSanPhamSapHet.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgSanPhamSapHet.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dtTuNgay.Value = DateTime.Today.AddMonths(-2);
            dtDenNgay.Value = DateTime.Now;
            LoadData(dtTuNgay.Value, dtDenNgay.Value);
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            dtTuNgay.Value = DateTime.Now;
            dtDenNgay.Value = DateTime.Now;
            LoadData(dtTuNgay.Value, dtDenNgay.Value);
        }


        private void btn30Ngay_Click(object sender, EventArgs e)
        {
            dtTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtDenNgay.Value = DateTime.Now;
            LoadData(dtTuNgay.Value, dtDenNgay.Value);
        }

        private void btn7ngayTruoc_Click_1(object sender, EventArgs e)
        {
            dtTuNgay.Value = DateTime.Now.AddDays(-7);
            dtDenNgay.Value = DateTime.Now;
            LoadData(dtTuNgay.Value,dtDenNgay.Value);
        }
    }
}
