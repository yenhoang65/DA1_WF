using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL;
namespace BLL
{
    public class BLLThongKe
    {
        DALThongKe daltk = new DALThongKe();

        public int? SoDonHang(DateTime tungay, DateTime denngay)
        {
            return daltk.SoDonHang(tungay, denngay);
        }

        public int? DoanhThu(DateTime tungay, DateTime denngay)
        {
            return daltk.DoanhThu(tungay, denngay);
        }
        public int? LoiNhuan(DateTime tungay, DateTime denngay)
        {
            return daltk.LoiNhuan(tungay, denngay);
        }
        public int? SoKhachHang(DateTime tungay, DateTime denngay)
        {
            return daltk.SoKhachHang(tungay, denngay);
        }
        public int? SoSanPham(DateTime tungay, DateTime denngay)
        {
            return daltk.SoSanPham(tungay, denngay);
        }
        public List<TKTheoNgay_Result> TKDTLN(DateTime tungay, DateTime denngay)
        {
            return daltk.TKDTLN(tungay, denngay);
        }
        public List<Top5BanChay_Result> Top5(DateTime tungay, DateTime denngay)
        {
            return daltk.Top5(tungay, denngay);
        }
    }
}
