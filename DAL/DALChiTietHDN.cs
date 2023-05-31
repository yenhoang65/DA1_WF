using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    
    public class DALChiTietHDN
    {
        taphoaEntities3 th = new taphoaEntities3();
        
        public List<chitiethdn> getAll()
        {
            return th.chitiethdns.ToList();
        }

        public void insert(chitiethdn c)
        {
            var sanpham = th.sanphams.Find(c.maSP);
            if (sanpham != null)
            {
                if (sanpham.soluong >= c.soluong)
                {
                    th.chitiethdns.Add(c);
                    sanpham.soluong += c.soluong;
                    th.SaveChanges();
                }
            }
        }

        public void edit(chitiethdn c)
        {
            chitiethdn ct = th.chitiethdns.Find(c.mahdn, c.maSP);
            if (ct != null)
            {
                ct.soluong = c.soluong;
                ct.gianhap = c.gianhap;
            }
        }

        public void delete(string mahdn, string masp)
        {
            chitiethdn h = th.chitiethdns.Find(mahdn, masp);
            th.chitiethdns.Remove(h);
            th.SaveChanges();
        }
    }
}
