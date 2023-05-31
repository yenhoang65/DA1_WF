using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALKhachHang
    {
        taphoaEntities3 th = new taphoaEntities3();

        public List<khachhang> getAll()
        {
            return th.khachhangs.ToList();
        }

        public void insert(khachhang kh)
        {
            th.khachhangs.Add(kh);
            th.SaveChanges();
        }

        public void edit(khachhang kh)
        {
            khachhang k = th.khachhangs.Find(kh.maKH);
            if(k!= null)
            {
                k.hoten = kh.hoten;
                k.sdt = kh.sdt;
            }
            th.SaveChanges();           
        }

        public void delete(string ma)
        {
            khachhang kh = th.khachhangs.Find(ma);
            th.khachhangs.Remove(kh);
            th.SaveChanges();
        }

        public List<SP_SearchKH_Result> Search(int sdt)
        {
            return th.SP_SearchKH(sdt).ToList();
        }
    }
}
