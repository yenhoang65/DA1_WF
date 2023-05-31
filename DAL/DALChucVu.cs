using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.DAL
{
    public class DALChucVu
    {
        taphoaEntities3 th = new taphoaEntities3();

        public List<ChucVu> getAll()
        {
            return th.ChucVus.ToList();
        }

        public void insert(ChucVu c)
        {
            th.ChucVus.Add(c);
            th.SaveChanges();
        }

        public void edit(ChucVu c)
        {
            ChucVu cv = th.ChucVus.Find(c.maCV);
            if (cv != null)
            {
                cv.tenCV = c.tenCV;
                cv.mota = c.mota;
            }
            th.SaveChanges();
        }

        public void delete(string ma)
        {
            ChucVu c = th.ChucVus.Find(ma);
            th.ChucVus.Remove(c);
            th.SaveChanges();
        }
    }
}
