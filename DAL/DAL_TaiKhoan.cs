using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        private DA1Entities db = new DA1Entities();

        public List<DangNhap> GetTaikhoans()
        {
            return db.DangNhaps.ToList();
        }
       


        public void Add(DangNhap taikhoan)
        {
            db.DangNhaps.Add(taikhoan);
            db.SaveChanges();
        }
        public void Update(DangNhap taikhoan)
        {
            DangNhap a = db.DangNhaps.Find(taikhoan.TaiKhoan);
            a.MatKhau = taikhoan.MatKhau;
            a.MaQuyen = taikhoan.MaQuyen;
            db.SaveChanges() ;
        }
        public void Delete(DangNhap taikhoan)
        {
            db.DangNhaps.Remove(taikhoan);
            db.SaveChanges() ;
        }

        
    }
}

