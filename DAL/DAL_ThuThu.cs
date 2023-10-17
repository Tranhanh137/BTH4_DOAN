using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DAL_ThuThu
    {
        private DA1Entities db = new DA1Entities();

        public ThuThu GetThuThuID(string id)
        {
            return db.ThuThus.Find(id);
        }
        public List<ThuThu> GetThuThus()
        {
            return db.ThuThus.ToList(); 
        }
        public void Add(ThuThu thuthu)
        {
            db.ThuThus.Add(thuthu);
            db.SaveChanges();
        }
        public void Update(ThuThu thuThu)
        {
            ThuThu s = db.ThuThus.SingleOrDefault(x => x.Ma == thuThu.Ma);
            s.Ten = thuThu.Ten;
            s.GioiTinh = thuThu.GioiTinh;
            s.SDT = thuThu.SDT;
            s.Email= thuThu.Email;  
            s.DiaChi = thuThu.DiaChi;
            s.MaQuyen = thuThu.MaQuyen;
            db.SaveChanges();
        }
        public void Delete(ThuThu thuThu)
        {
            db.ThuThus.Remove(thuThu);  
            db.SaveChanges();
        }
    }
}
