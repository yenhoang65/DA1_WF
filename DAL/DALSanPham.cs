using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALSanPham
    {
        taphoaEntities3 th = new taphoaEntities3();

        public List<sanpham> getAll()
        {
            return th.sanphams.ToList();
        }

        public void insert(sanpham sp)
        {
            th.sanphams.Add(sp);
            th.SaveChanges();
        }

        public void edit(sanpham sp)
        {
            sanpham s = th.sanphams.Find(sp.masp);
            if(s != null)
            {
                s.tensp = sp.tensp;
                s.xuatxu = sp.xuatxu;
                s.giaban = sp.giaban;
                s.soluong = sp.soluong;
            }
            th.SaveChanges();
        }

        public void delete(string masp)
        {
            sanpham sp = th.sanphams.Find(masp);
            th.sanphams.Remove(sp);
            th.SaveChanges();
        }

        public List<SP_SearchSP_Result> Search(string ten)
        {
            return th.SP_SearchSP(ten).ToList();
        }
    }
}
