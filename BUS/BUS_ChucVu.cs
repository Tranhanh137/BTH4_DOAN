using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChucVu
    {
        private DAL_ChucVu dalChucvu = new DAL_ChucVu();    

        public List<Quyen> GetChucvus()
        {
            return dalChucvu.GetChucvus();
        }
    }
}
