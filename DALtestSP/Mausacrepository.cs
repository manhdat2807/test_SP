using DALtestSP.DAL_dat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALtestSP
{
    public class Mausacrepository
    {
        Qlbgpro3Context context;
        public Mausacrepository()
        {
            context = new Qlbgpro3Context();
        }
        public List<Mausac> getallms()
        {
            return context.Mausacs.ToList();
        }
        public bool themms(Mausac ms)
        {
            if (ms != null)
            {
                context.Mausacs.Add(ms);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool capnhapms(Mausac ms)
        {
            if (ms != null)
            {
                context.Mausacs.Update(ms);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
