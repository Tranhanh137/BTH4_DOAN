using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class BUS_ThuThu
    {
        private DAL_ThuThu dalThuthu = new DAL_ThuThu();    

        public ThuThu GetThuThuID(string id)
        {
            return dalThuthu.GetThuThuID(id);   
        }
        public List<ThuThu> GetThuThus()
        {
            return dalThuthu.GetThuThus();
        }
        public void Add(ThuThu thuThu)
        {
            dalThuthu.Add(thuThu);
        }
        public void Update(ThuThu s)
        {
            dalThuthu.Update(s);
        }
        public void Delete(ThuThu thuThu)
        {
            dalThuthu.Delete(thuThu);
        }
    }
}
