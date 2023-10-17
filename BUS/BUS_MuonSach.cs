using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;           

namespace BUS
{
   public class BUS_MuonSach
    {
        private DAL_MuonSach dalMuonSach = new DAL_MuonSach();
        private DAL_Sach dalSach = new DAL_Sach();
        

        public List<MuonSach> GetMuonSaches()
        {
            return dalMuonSach.GetMuonSaches();
        }
         public int GetNewID()
        {
            List<MuonSach> muonSachs = dalMuonSach.GetMuonSaches();
            if (muonSachs.Count == 0) return 1;
            else return muonSachs.Last().Ma + 1;
        }
        public void Add(MuonSach muonSach)
        {
            dalMuonSach.Add(muonSach);
            foreach (CTMuonSach chiTietPhieuMuon in muonSach.CTMuonSaches)
            {
                Sach sach = dalSach.GetSachs().FirstOrDefault(s => s.Ma == chiTietPhieuMuon.MaSach);
                sach.SoLuong -= chiTietPhieuMuon.SoLuong;
                dalSach.Update(sach);
            }
        }
        public void Update(MuonSach muonSach)
        {
         dalMuonSach.Update(muonSach);
        }
        public void Delete(MuonSach muonSach)
        {
            dalMuonSach.Delete(muonSach);
        }
    }
}
