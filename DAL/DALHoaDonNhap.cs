using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALHoaDonNhap
    {
        taphoaEntities3 th = new taphoaEntities3();

        public List<hdn> getAll()
        {
            return th.hdns.ToList();
        }

        public void insert(hdn h)
        {
            th.hdns.Add(h);
            th.SaveChanges();
        }

        public void edit(hdn h)
        {
            hdn hdn = th.hdns.Find(h.mahdn);
            if(hdn != null)
            {
                hdn.manv = h.manv;
                hdn.mancc = h.mancc;
                hdn.ngayNhap = h.ngayNhap;
            }
            th.SaveChanges();
        }

        public void delete(string mahdn)
        {
            hdn h = th.hdns.Find(mahdn);
            th.hdns.Remove(h);
            th.SaveChanges();
        }
        public List<SearchHDN_Result> Search(DateTime tungay, DateTime denngay, string ten)
        {
            return th.SearchHDN(tungay, denngay, ten).ToList<SearchHDN_Result>();
        }
    }
}
