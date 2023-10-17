using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SinhVien
    {
        private DAL_SinhVien dalSinhVien = new DAL_SinhVien();

        private List<SinhVien> sinhvienList = new List<SinhVien>();

        public List<SinhVien> GetSinhViens()
        {
            return dalSinhVien.GetSinhViens();
        }
        public int GetNewID()
        {
            sinhvienList = GetSinhViens();
            if (sinhvienList.Count == 0) return 1;
            else return sinhvienList.Last().Ma + 1;
        }
        public void Add(SinhVien sinhvien)
        {
            sinhvien.Ma = GetNewID();
            dalSinhVien.Add(sinhvien);
        }
        public void Update(SinhVien sinhvien)
        {
            dalSinhVien.Update(sinhvien);
        }
        public void Delete(SinhVien sinhvien)
        {
            dalSinhVien.Delete(sinhvien);
        }
    }
}
