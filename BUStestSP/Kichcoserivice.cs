using DALtestSP;
using DALtestSP.DAL_dat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUStestSP
{
    public class Kichcoserivice
    {
        Kichcorepository kcrepos;
        public Kichcoserivice()
        {
            kcrepos = new Kichcorepository();
        }
        public List<Kichco>GetKichcos()
        {
            return kcrepos.getallkc();
        }
        public string addkc(Kichco kc)
        {
            if (kcrepos.themkc(kc))
            {
                return "thêm thành công";
            }
            return "thêm thất bại";
        }
        public string updatekc(Kichco kc)
        {
            if (kcrepos.capnhapkc(kc))
            {
                return "Cập nhập thành công";
            }
            return "Cập nhập  thất bại";
        }
    }
}
