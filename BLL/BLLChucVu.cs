using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAL;
using DAL.Entities;


namespace BLL
{
    public class BLLChucVu
    {
        DALChucVu dalcv = new DALChucVu();

        public List<ChucVu> getAll()
        {
            return dalcv.getAll();
        }

        public void insert(ChucVu c)
        {
            dalcv.insert(c);
        }

        public void edit(ChucVu c)
        {
            dalcv.edit(c);
        }

        public void delete(string ma)
        {
            dalcv.delete(ma);
        }
    }
}
