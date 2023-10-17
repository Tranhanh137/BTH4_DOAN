using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TraSach
    {
        private DA1Entities db = new DA1Entities();

        public List<TraSach> GetTraSaches()
        {
            return db.TraSaches.ToList();
        }
        public void Add(TraSach traSach)
        {
            db.TraSaches.Add(traSach);
            db.SaveChanges();
        }
        public void Delete(TraSach traSach)
        {
            db.TraSaches.Remove(traSach);
            db.SaveChanges();
        }
    }
}
