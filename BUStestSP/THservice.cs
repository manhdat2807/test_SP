using DALtestSP;
using DALtestSP.DAL_dat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUStestSP
{
    public class THservice
    {
        THrepository threpos;
        public THservice()
        {
            threpos = new THrepository();
        }
        public List<Thuonghieu>GetThuonghieus()
        {
            return threpos.getallth();
        }
        public string addth(Thuonghieu th)
        {
            if (threpos.themth(th))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updateth(Thuonghieu th)
        {
            if (threpos.capnhapth(th))
            {
                return "Cập nhập thành công";
            }
            return "Cập nhập  thất bại";
        }
    }
}
