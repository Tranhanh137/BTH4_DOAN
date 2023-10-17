using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        private DAL_TaiKhoan dalTaikhoan = new DAL_TaiKhoan();

        public static DangNhap currentTaikhoan = null;

        private List<DangNhap> taikhoans = new List<DangNhap>();

        public List<DangNhap> GetTaikhoans()
        {
            return dalTaikhoan.GetTaikhoans();
        }
      
        public bool CheckUn(string un)
        {
            taikhoans = GetTaikhoans();
            return taikhoans.SingleOrDefault(a => a.TaiKhoan == un) != null;
        }
        public DangNhap GetTaikhoan(string un, string pw)
        {
            taikhoans = GetTaikhoans();
            return taikhoans.FirstOrDefault(a => a.TaiKhoan == un && a.MatKhau == pw);
        }

      
        public void Add(DangNhap taikhoan)
        {
            dalTaikhoan.Add(taikhoan);
        }
        public void Update(DangNhap taikhoan)
        {
            dalTaikhoan.Update(taikhoan);
        }
        public void Delete(DangNhap taikhoan)
        {
            dalTaikhoan.Delete(taikhoan);
        }
    }
}
