using DALtestSP;
using DALtestSP.DAL_dat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUStestSP
{
    public class XXservice
    {
        Xuatxurepository xxrepos;
        public XXservice()
        {
            xxrepos = new Xuatxurepository();
        }
        public List<Xuatxu> GetXuatxus()
        {
            return xxrepos.getallsxx();
        }
        public string addxx(Xuatxu xx)
        {
            if (xxrepos.themxx(xx))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updatexx(Xuatxu xx)
        {
            if (xxrepos.capnhapxx(xx))
            {
                return "Cập nhập thành công";
            }
            return "Cập nhập  thất bại";
        }
    }
}
