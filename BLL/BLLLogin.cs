using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace BLL
{
    public class BLLLogin
    {
        DALLogin dallogin = new DALLogin();
        public NhanVien getUser(string un, string pw)
        {
            return dallogin.getUser(un, pw);
        }
    }
}
