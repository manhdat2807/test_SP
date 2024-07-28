using DALtestSP.DAL_dat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALtestSP
{
    public class Kichcorepository
    {
        Qlbgpro3Context context;
        public Kichcorepository()
        {
            context = new Qlbgpro3Context();
        }
        public List<Kichco> getallkc()
        {
            return context.Kichcos.ToList();
        }
        public bool themkc(Kichco kc)
        {
            if (kc != null)
            {
                context.Kichcos.Add(kc);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool capnhapkc(Kichco kc)
        {
            if (kc != null)
            {
                context.Kichcos.Update(kc);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
