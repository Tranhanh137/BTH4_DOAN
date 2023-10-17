using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Sach
    {
        private DAL_Sach dalSach = new DAL_Sach();
        private List<Sach> saches = new List<Sach>();

        public List<Sach> GetSaches()
        {
            return dalSach.GetSachs();
        }

        public int GetNewID()
        {
            List<Sach> saches = GetSaches();
            if (saches.Count == 0) return 1;
            else return saches.Last().Ma + 1;
        }
        public List<Sach> searchSachbyLS(int maLS)
        {
            return GetSaches().Where(x => x.MaLS == maLS).ToList();
        }
        public void Add(Sach sach)
        {
            dalSach.Add(sach);
        }

        public void Update(Sach sach)
        {
            dalSach.Update(sach);
        }
        public void Delete(Sach sach)
        {
            dalSach.Delete(sach);   
        }

    }

}
