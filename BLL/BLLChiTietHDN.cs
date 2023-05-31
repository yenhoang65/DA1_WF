using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL
{
    public class BLLChiTietHDN
    {
        DALChiTietHDN dalcthdn = new DALChiTietHDN();

        public List<chitiethdn> getAll()
        {
            return dalcthdn.getAll();
        }

        public void insert(chitiethdn c)
        {
            dalcthdn.insert(c);
        }

        public void edit(chitiethdn c)
        {
            dalcthdn.edit(c);
        }

        public void delete(string mahdn, string masp)
        {
            dalcthdn.delete(mahdn, masp);
        }
    }
}
