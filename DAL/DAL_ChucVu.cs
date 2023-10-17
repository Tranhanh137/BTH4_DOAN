using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChucVu
    {
        private DA1Entities db = new DA1Entities();

        public List<Quyen> GetChucvus() 
        {
            return db.Quyens.ToList();
        }
    }
}
