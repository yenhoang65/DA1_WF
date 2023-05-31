using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALChiTietHDB
    {
        taphoaEntities3 th = new taphoaEntities3();
        public List<chitiethdb> getAll()
        {
            return th.chitiethdbs.ToList();
        }

        public void insert(chitiethdb c)
        {
            var sanpham = th.sanphams.Find(c.maSP);
            if (sanpham != null)
            {
                if (sanpham.soluong >= c.soluong)
                {
                    th.chitiethdbs.Add(c);
                    sanpham.soluong -= c.soluong;
                    th.SaveChanges();
                }
            }
        }

        public void edit(chitiethdb c)
        {
            var cthd = th.chitiethdbs.FirstOrDefault(ct => ct.mahdb == c.mahdb && ct.maSP == c.maSP);

            if (cthd != null)
            {
                var sanPham = th.sanphams.Find(c.maSP);

                if (sanPham != null)
                {
                    int? soLuongCu = cthd.soluong;

                    if (sanPham.soluong + soLuongCu >= c.soluong)
                    {
                        cthd.soluong = c.soluong;

                        sanPham.soluong = sanPham.soluong + soLuongCu - c.soluong;

                        th.SaveChanges();
                    }

                }
            }
        }

        public void delete(string mahdb, string masp)
        {

            var existingCTHDB = th.chitiethdbs.FirstOrDefault(ct => ct.mahdb == mahdb && ct.maSP == masp);

            if (existingCTHDB != null)
            {
                var sanPham = th.sanphams.Find(masp);

                if (sanPham != null)
                {
                    sanPham.soluong += existingCTHDB.soluong;

                    th.chitiethdbs.Remove(existingCTHDB);

                    th.SaveChanges();
                }
            }
        }
    }
}
