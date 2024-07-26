using DALtestSP.DAL_dat;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALtestSP
{
    public class SPrepository
    {
        Qlbgpro3Context context;
        public SPrepository()
        {
            context = new Qlbgpro3Context();
        }
        public List<Sanpham> getallsp()
        {
            return context.Sanphams.ToList();
        }
        public bool themsp(Sanpham sp)
        {
            if (sp != null)
            {
                context.Sanphams.Add(sp);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool capnhapsp(Sanpham sp)
        {
            if (sp != null)
            {
                context.Sanphams.Update(sp);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
