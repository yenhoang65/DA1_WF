using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALNhanVien
    {
        taphoaEntities3 th = new taphoaEntities3();
        public List<NhanVien> getAll()
        {
            return th.NhanViens.ToList();
        }

        public void insert(NhanVien nv)
        {
            th.NhanViens.Add(nv);
            th.SaveChanges();
        }

        public void edit(NhanVien nv)
        {
            NhanVien n = th.NhanViens.Find(nv.maNV);
            
            if(n != null)
            {
                n.hoten = nv.hoten;
                n.namsinh = nv.namsinh;
                n.sdt = nv.sdt;
                n.maCV = nv.maCV;
                n.gioitinh = nv.gioitinh;
                n.pw = nv.pw;
            }
            th.SaveChanges();
        }   

        public void delete(string ma)
        {
            NhanVien nv = th.NhanViens.Find(ma);
            th.NhanViens.Remove(nv);
            th.SaveChanges();
        }

        public List<SP_SearchNV_Result> Search(string manv)
        {
            return th.SP_SearchNV(manv).ToList();
        }
    }
}
