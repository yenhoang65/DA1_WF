using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL
{
    public class BLLKhachHang
    {
        DALKhachHang dalkh = new DALKhachHang();

        public List<khachhang> getAll()
        {
            return dalkh.getAll();
        }

        public void insert(khachhang kh)
        {
            dalkh.insert(kh);
        }

        public void edit(khachhang kh)
        {
            dalkh.edit(kh);
        }

        public void delete(string ma)
        {
            dalkh.delete(ma);
        }

        public List<SP_SearchKH_Result> Search(int sdt)
        {
            return dalkh.Search(sdt);
        }
    }
}
