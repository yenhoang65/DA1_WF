using BLL;
using DAL;
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
    public partial class frmSanPham : Form
    {

        BLLSanPham bllsp = new BLLSanPham();

        public frmSanPham()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void New()
        {
            errorProvider1.Clear();
            errorProvider4.Clear();
            loadDg(dgSP, dt(bllsp.getAll()));
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            New();
        }

        private DataGridView loadDg(DataGridView dg, DataTable dt)
        {
            dg.DataSource = dt;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return dg;
        }

        private DataTable dt(List<sanpham> list)
        {
            //List<sanpham> list = bllsp.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm");
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Xuất xứ");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Gía bán");
            foreach (sanpham sp in list)
            {
                DataRow row = dt.NewRow();
                row["Mã sản phẩm"] = sp.masp;
                row["Tên sản phẩm"] = sp.tensp;
                row["Xuất xứ"] = sp.xuatxu;
                row["Số lượng"] = sp.soluong;
                row["Gía bán"] = sp.giaban;
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            txtMaSanPham.Text = "";
            txtTenSP.Text = "";
            txtXuatXuSP.Text = "";
            txtSoLuongSP.Text = "";
            txtGiaBanSP.Text = "";
            txtTkTenSP.Text = "";
            New();
        }

        private void dgSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaSanPham.Text = dgSP[0, hang].Value.ToString();
            txtTenSP.Text = dgSP[1, hang].Value.ToString();
            txtXuatXuSP.Text = dgSP[2, hang].Value.ToString();
            txtSoLuongSP.Text = dgSP[3, hang].Value.ToString();
            txtGiaBanSP.Text = dgSP[4, hang].Value.ToString();
        }

        private bool KiemTraThongTin(string tenmt, string xuatxu, bool kt)
        {
            int flag = 0;
            if (tenmt.Trim() != "")
            {
                errorProvider1.Clear();

            }
            else
            {
                flag = 1;
                errorProvider1.SetError(txtTenSP, "Tên sản phẩm không được để trống");
            }
            if (xuatxu != "")
            {
                errorProvider4.Clear();

            }
            else
            {
                flag = 1;
                errorProvider4.SetError(txtXuatXuSP, "Chưa nhập xuất xứ");
            }
            if (flag == 0)
                kt = true;
            else
                kt = false;
            return kt;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham();
            sp.masp = txtMaSanPham.Text;
            sp.tensp=txtTenSP.Text;
            sp.xuatxu = txtXuatXuSP.Text;
            sp.soluong = int.Parse(txtSoLuongSP.Text);
            sp.giaban = int.Parse(txtGiaBanSP.Text);

            bool b = false;
            b = KiemTraThongTin(txtTenSP.Text + "", txtXuatXuSP.Text + "", b);
            if (b == true)
            {
                bllsp.insert(sp);
                MessageBox.Show("Thêm thành công");
                New();
            }
            
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham();
            sp.masp = txtMaSanPham.Text;
            sp.tensp = txtTenSP.Text;
            sp.xuatxu = txtXuatXuSP.Text;
            sp.soluong = int.Parse(txtSoLuongSP.Text);
            sp.giaban = int.Parse(txtGiaBanSP.Text);

            bool b = false;
            b = KiemTraThongTin(txtTenSP.Text + "", txtXuatXuSP.Text + "", b);
            if (b == true)
            {
                    bllsp.edit(sp);
                    MessageBox.Show("Sửa thành công");
                    New();
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham();
            bllsp.delete(txtMaSanPham.Text);
            New();
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            List<SP_SearchSP_Result> lncc = bllsp.Search(txtTkTenSP.Text);
            List<sanpham> listsp = bllsp.getAll();
            List<sanpham> list = new List<sanpham>();
            foreach (var i in lncc)
            {
                foreach (var j in listsp)
                {
                    if (i.masp == j.masp)
                    {
                        list.Add(j);
                    }
                }
            }
            loadDg(dgSP, dt(list));
        }

        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {
            List<sanpham> list = bllsp.getAll();
            bool thuoc = false;
            btnThemSP.Enabled = true;
            btnSuaSP.Enabled = false;
            btnXoaSP.Enabled = false;
            for (int i = 0; i < list.Count; i++)
            {

                if (txtMaSanPham.Text == list[i].masp)
                {
                    thuoc = true;
                    btnThemSP.Enabled = false;
                    btnSuaSP.Enabled = true;
                    btnXoaSP.Enabled = true;
                    break;
                }
            }
            if (thuoc == false)
            {
                txtTenSP.Text = "";
                txtXuatXuSP.Text = "";
                txtSoLuongSP.Text = "0";
                txtGiaBanSP.Text = "0";
            }

        }
    }
}
