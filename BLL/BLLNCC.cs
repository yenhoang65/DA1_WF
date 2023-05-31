using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL
{
    public class BLLNCC
    {
        DALNCC dalncc = new DALNCC();

        public List<ncc> getAll()
        {
            return dalncc.getAll();
        }

        public void insert(ncc n)
        {
            dalncc.insert(n);
        }

        public void edit(ncc n)
        {
            dalncc.edit(n);
        }

        public void delete(string ma)
        {
            dalncc.delete(ma);
        }

        public List<SP_SearchNCC_Result> Search(int sdt)
        {
            return dalncc.Search(sdt);
        }
    }
}
