using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALThongKe
    {
        taphoaEntities3 th = new taphoaEntities3();

        public int? SoDonHang(DateTime tungay, DateTime denngay)
        {
            return th.TongDonHang(tungay, denngay).FirstOrDefault();
        }

        public int? DoanhThu(DateTime tungay, DateTime denngay)
        {
            return th.DoanhThu(tungay, denngay).FirstOrDefault(); ;
        }
        public int? LoiNhuan(DateTime tungay, DateTime denngay)
        {
            return th.LoiNhuan(tungay, denngay).FirstOrDefault();
        }
        public int? SoKhachHang(DateTime tungay, DateTime denngay)
        {
            return th.SoKhachHang(tungay, denngay).FirstOrDefault();
        }
        public int? SoSanPham(DateTime tungay, DateTime denngay)
        {
            return th.TongSanPham(tungay, denngay).FirstOrDefault();
        }
        public List<TKTheoNgay_Result> TKDTLN(DateTime tungay, DateTime denngay)
        {
            return th.TKTheoNgay(tungay, denngay).ToList<TKTheoNgay_Result>();
        }
        public List<Top5BanChay_Result> Top5(DateTime tungay, DateTime denngay)
        {
            return th.Top5BanChay(tungay, denngay).ToList();
        }
    }
}
