using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL
{
    public class BLLNhanVien
    {
        DALNhanVien dalnv = new DALNhanVien();

        public List<NhanVien> getAll()
        {
            return dalnv.getAll();
        }

        public void insert(NhanVien nv)
        {
            dalnv.insert(nv);
        }

        public void edit(NhanVien nv)
        {
            dalnv.edit(nv);
        }

        public void delete(string ma)
        {
            dalnv.delete(ma);
        }

        public List<SP_SearchNV_Result> Search(string manv)
        {
            return dalnv.Search(manv);
        }
    }
}
