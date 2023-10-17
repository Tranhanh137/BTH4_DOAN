using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TraSach
    {
        private DAL_TraSach dalTraSach = new DAL_TraSach();

        public List<TraSach> GetTraSaches()
        {
            return dalTraSach.GetTraSaches();
        }
        public int GetNewID()
        {
            List<TraSach> traSachs = dalTraSach.GetTraSaches();
            if (traSachs.Count == 0) return 1;
            else return traSachs.Last().Ma + 1;
        }
        public void Add(TraSach traSach)
        {
            dalTraSach.Add(traSach);
        }
    }
}
        
        
        
    
