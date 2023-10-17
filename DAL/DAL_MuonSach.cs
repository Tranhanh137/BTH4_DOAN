using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MuonSach
    {
        private DA1Entities db = new DA1Entities();

        public List<MuonSach> GetMuonSaches()
        {
            return db.MuonSaches.ToList();
        }

        public void Add(MuonSach muonSach)
        {
            db.MuonSaches.Add(muonSach);
            db.SaveChanges();
        }

        public void Update(MuonSach muonSach) 
        {
            MuonSach b = db.MuonSaches.Find(muonSach.Ma);
            b.ThuThu = muonSach.ThuThu;
            b.MaSV = muonSach.MaSV;
            b.NgayMuon = muonSach.NgayMuon;
            db.SaveChanges();
        }
        public void Delete(MuonSach muonSach)
        {
            db.MuonSaches.Remove(muonSach);
            db.SaveChanges();
        }
    }
}
