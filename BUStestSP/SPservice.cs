using DALtestSP;
using DALtestSP.DAL_dat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUStestSP
{
    public  class SPservice
    {
        SPrepository sprepos;
        public SPservice()
        {
            sprepos = new SPrepository();
        }
        public List<Sanpham>GetSanphams()
        {
            return sprepos.getallsp();
        }
        public  string addsp(Sanpham sp)
        {
            if (sprepos.themsp(sp))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updatesp(Sanpham sp)
        {
            if (sprepos.capnhapsp(sp))
            {
                return "Cập nhập thành công";
            }
            return "Cập nhập  thất bại";
        }
    }
}
