using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL
{
    public class BLLSanPham
    {
        DALSanPham dalsp = new DALSanPham();

        public List<sanpham> getAll()
        {
            return dalsp.getAll();
        }

        public void insert(sanpham sp)
        {
            dalsp.insert(sp);
        }

        public void edit(sanpham sp)
        {
            dalsp.edit(sp);
        }

        public void delete(string ma)
        {
            dalsp.delete(ma);
        }

        public List<SP_SearchSP_Result> Search(string ten)
        {
            return dalsp.Search(ten);
        }
    }
}
