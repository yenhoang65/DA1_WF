using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALNCC
    {
        taphoaEntities3 th = new taphoaEntities3();
        public List<ncc> getAll()
        {
            return th.nccs.ToList();
        }

        public void insert(ncc n)
        {
            th.nccs.Add(n);
            th.SaveChanges();
        }

        public void edit(ncc n)
        {
            ncc ncc = th.nccs.Find(n.mancc);
            if (ncc != null)
            {
                ncc.tenncc = n.tenncc;
                ncc.sdt = n.sdt;
                ncc.diachi = n.diachi;
            }
            th.SaveChanges();
        }

        public void delete(string ma)
        {
            ncc n = th.nccs.Find(ma);
            th.nccs.Remove(n);
            th.SaveChanges();
        }

        public List<SP_SearchNCC_Result> Search(int sdt)
        {
            return th.SP_SearchNCC(sdt).ToList();
        }
    }
}
