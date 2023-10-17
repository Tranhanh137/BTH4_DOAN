using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LoaiSach
    {
        private DAL_LoaiSach dalLoaiSach = new DAL_LoaiSach();
        private List<LoaiSach> loaiSachs = new List<LoaiSach>();

        public List<LoaiSach> GetLoaiSachs()
        {
            return dalLoaiSach.GetLoaiSachs();
        }
        public int GetNewID()
        {
            List<LoaiSach> loaisach = GetLoaiSachs();
            if (loaisach.Count == 0) return 1;
            else return loaisach.Last().Ma + 1;
        }
        public void Add(LoaiSach loaiSach)
        {
            dalLoaiSach.Add(loaiSach);
        }
        public void Update(LoaiSach loaiSach)
        {
            dalLoaiSach.Update(loaiSach);
        }
        public void Delete(LoaiSach loaiSach)
        {
            dalLoaiSach.Delete(loaiSach);
        }
    }
}
