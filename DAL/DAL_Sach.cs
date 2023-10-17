using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Sach
    {
        private DA1Entities db = new DA1Entities();

        public List<Sach> GetSachs()
        {
            return db.Saches.ToList();
        }

        public void Add(Sach sach)
        {
            db.Saches.Add(sach);
            db.SaveChanges();
        }
        public void Update(Sach sach)
        {
            Sach cp = db.Saches.Find(sach.Ma);
            cp.Ten = sach.Ten;
            db.SaveChanges();
        }
        public void Delete(Sach sach)
        {
            db.Saches.Remove(sach);
            db.SaveChanges();
        }
    }
}
