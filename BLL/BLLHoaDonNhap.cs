using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL
{
    public class BLLHoaDonNhap
    {
        DALHoaDonNhap dalhdn = new DALHoaDonNhap();

        public List<hdn> getAll()
        {
           return dalhdn.getAll();
        }

        public void insert(hdn h)
        {
            dalhdn.insert(h);
        }

        public void edit(hdn h)
        {
            dalhdn.edit(h);
        }

        public void delete(string mahdn)
        {
            dalhdn.delete(mahdn);
        }
        public List<SearchHDN_Result> SearchHDN(DateTime tungay, DateTime denngay, string ten)
        {
            return dalhdn.Search(tungay, denngay, ten);
        }
    }
}
