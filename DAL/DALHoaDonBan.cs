using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALHoaDonBan
    {
        taphoaEntities3 th = new taphoaEntities3();
        public List<hoadonban> getAll()
        {
            return th.hoadonbans.ToList();
        }

        public void insert(hoadonban hdb)
        {
            th.hoadonbans.Add(hdb);
            th.SaveChanges();
        }

        public void edit(hoadonban h)
        {
            hoadonban hdb = th.hoadonbans.Find(h.mahdb);
            if(hdb != null)
            {
                hdb.maNV = h.maNV;
                hdb.maKH = h.maKH;
                hdb.ngayBan = h.ngayBan;
                hdb.hinhthucthanhtoan = h.hinhthucthanhtoan;
            }
            th.SaveChanges();
        }

        public void delete(string ma)
        {
            hoadonban h = th.hoadonbans.Find(ma);
            th.hoadonbans.Remove(h);
            th.SaveChanges();
        }

        public List<SearchHDB_Result> Search(DateTime tungay, DateTime denngay, int sdt)
        {
            return th.SearchHDB(tungay, denngay, sdt).ToList<SearchHDB_Result>();
        }
    }
}
