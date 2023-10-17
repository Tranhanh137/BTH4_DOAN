using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_CTMuonSach
    {
        private DAL_CTMuonSach dalCTMuonSach = new DAL_CTMuonSach();
        private List<CTMuonSach> ctMuonSaches = new List<CTMuonSach>();

        public List<CTMuonSach> GetCTMuonSaches()
        {
            ctMuonSaches = dalCTMuonSach.GetCTMuonSaches();
            return ctMuonSaches;
        }

        public int GetNewID()
        {
            ctMuonSaches = GetCTMuonSaches();
            if (ctMuonSaches.Count == 0) return 1;
            else return ctMuonSaches.Last().Ma + 1;
        }
        public void AddAmount(CTMuonSach bd, int amount, string note)
        {
            bd.SoLuong += amount;
            if (string.IsNullOrWhiteSpace(bd.GhiChu))
                bd.GhiChu = note;
            else
                bd.GhiChu += ", " + note;
            dalCTMuonSach.Update(bd);
        }
        public void Add(CTMuonSach ctMuonSach)
        {
            dalCTMuonSach.Add(ctMuonSach);
        }
        public void Update(CTMuonSach ctMuonSach)
        {
            dalCTMuonSach.Update(ctMuonSach);
        }
        public void Delete(CTMuonSach ctMuonSach)
        {
            dalCTMuonSach.Delete(ctMuonSach);
        }
    }
}
