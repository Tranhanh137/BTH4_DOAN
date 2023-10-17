using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiSach
    {
        private DA1Entities db = new DA1Entities();

        public List<LoaiSach> GetLoaiSachs()
        {
            return db.LoaiSaches.ToList();
        }
        public void Add(LoaiSach loaiSach)
        {
            db.LoaiSaches.Add(loaiSach);
            db.SaveChanges();
        }
        public void Update(LoaiSach loaiSach)
        {
            LoaiSach ls = db.LoaiSaches.Find(loaiSach.Ma);
            ls.Ten = loaiSach.Ten;
            db.SaveChanges();
        }
        public void Delete(LoaiSach loaiSach)
        {
            db.LoaiSaches.Remove(loaiSach);
            db.SaveChanges();
        }
    }
}
