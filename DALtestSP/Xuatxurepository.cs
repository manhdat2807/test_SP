using DALtestSP.DAL_dat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALtestSP
{
    public class Xuatxurepository
    {
        Qlbgpro3Context context;
        public Xuatxurepository()
        {
            context = new Qlbgpro3Context();
        }
        public List<Xuatxu> getallsxx()
        {
            return context.Xuatxus.ToList();
        }
        public bool themxx(Xuatxu xx)
        {
            if (xx != null)
            {
                context.Xuatxus.Add(xx);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool capnhapxx(Xuatxu xx)
        {
            if (xx != null)
            {
                context.Xuatxus.Update(xx);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
