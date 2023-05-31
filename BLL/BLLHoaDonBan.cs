using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL
{
    public class BLLHoaDonBan
    {
        DALHoaDonBan dalhdb = new DALHoaDonBan();
        public List<hoadonban> getAll()
        {
            return dalhdb.getAll();
        }

        public void insert(hoadonban h)
        {
            dalhdb.insert(h);
        }

        public void edit(hoadonban h)
        {
            dalhdb.edit(h);
        }

        public void delete(string ma)
        {
            dalhdb.delete(ma);
        }
        public List<SearchHDB_Result> SearchHDB(DateTime tungay, DateTime denngay, int sdt)
        {
            return dalhdb.Search(tungay, denngay, sdt);
        }
    }
}
