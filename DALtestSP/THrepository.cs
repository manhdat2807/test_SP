using DALtestSP.DAL_dat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALtestSP
{
    public class THrepository
    {
        Qlbgpro3Context context;
        public THrepository()
        {
            context = new Qlbgpro3Context();
        }
        public List<Thuonghieu> getallth()
        {
            return context.Thuonghieus.ToList();
        }
        public bool themth(Thuonghieu th)
        {
            if (th != null)
            {
                context.Thuonghieus.Add(th);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool capnhapth(Thuonghieu th)
        {
            if (th != null)
            {
                context.Thuonghieus.Update(th);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
