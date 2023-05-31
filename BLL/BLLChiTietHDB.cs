using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL
{
    public class BLLChiTietHDB
    {
        DALChiTietHDB dalChiTietHDB = new DALChiTietHDB();

        public List<chitiethdb> getAll()
        {
            return dalChiTietHDB.getAll();
        }

        public void insert(chitiethdb c)
        {
            dalChiTietHDB.insert(c);
        }

        public void edit(chitiethdb c)
        {
            dalChiTietHDB.edit(c);
        }

        public void delete(string mahdb, string masp)
        {
            dalChiTietHDB.delete(mahdb, masp);
        }
    }
}
