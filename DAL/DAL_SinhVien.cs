using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SinhVien
    {
        private DA1Entities db = new DA1Entities();

        public List<SinhVien> GetSinhViens()
        {
            return db.SinhViens.ToList();
        }
        public void Add(SinhVien sinhVien)
        {
            db.SinhViens.Add(sinhVien);
            db.SaveChanges();
        }
        public void Update(SinhVien sinhVien)
        {
            SinhVien s = db.SinhViens.SingleOrDefault(x => x.Ma == sinhVien.Ma);
            s.Ten = sinhVien.Ten;
            s.GioiTinh = sinhVien.GioiTinh;
            s.SDT = sinhVien.SDT;
            s.Lop = sinhVien.Lop;
            s.Email = sinhVien.Email;
            db.SaveChanges();
        }
        public void Delete(SinhVien sinhVien)
        {
            db.SinhViens.Remove(sinhVien);
            db.SaveChanges();
        }
    }

    
}
