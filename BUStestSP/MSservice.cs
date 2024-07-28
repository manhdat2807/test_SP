using DALtestSP;
using DALtestSP.DAL_dat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUStestSP
{
    public class MSservice
    {
        Mausacrepository msrepos;
        public MSservice()
        {
            msrepos = new Mausacrepository();
        }
        public List<Mausac> GetMausacs()
        {
            return msrepos.getallms();
        }
        public string addms(Mausac ms)
        {
            if (msrepos.themms(ms))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updatams(Mausac ms)
        {
            if (msrepos.capnhapms(ms))
            {
                return "Cập nhập thành công";
            }
            return "Cập nhập  thất bại";
        }
    }
}
