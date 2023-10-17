using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CTMuonSach
    {
        private DA1Entities db = new DA1Entities();

        public List<CTMuonSach> GetCTMuonSaches()
        {
            return db.CTMuonSaches.ToList();
        }
        public void Add(CTMuonSach ctMuonSach)
        {
            ctMuonSach.Sach = db.Saches.Find(ctMuonSach.MaSach);
            db.CTMuonSaches.Add(ctMuonSach);
            db.SaveChanges();
        }
        public void Update(CTMuonSach ctMuonSach)
        {

            CTMuonSach bd = db.CTMuonSaches.Find(ctMuonSach.Ma);
            bd.MaMS = ctMuonSach.MaMS;
            bd.MaSach = ctMuonSach.MaSach;
            bd.SoLuong = ctMuonSach.SoLuong;
            bd.GhiChu = ctMuonSach.GhiChu;
            db.SaveChanges();
        }
        public void Delete(CTMuonSach ctMuonSach)
        {
            db.CTMuonSaches.Remove(ctMuonSach);
            db.SaveChanges();
        }
    }
}
