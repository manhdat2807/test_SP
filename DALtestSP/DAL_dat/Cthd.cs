using System;
using System.Collections.Generic;

namespace DALtestSP.DAL_dat;

public partial class Cthd
{
    public string MaCthd { get; set; } = null!;

    public string MaHd { get; set; } = null!;

    public string Masp { get; set; } = null!;

    public string Manv { get; set; } = null!;

    public int Soluong { get; set; }

    public bool? Trangthai { get; set; }

    public virtual Hoadon MaHdNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;

    public virtual Sanpham MaspNavigation { get; set; } = null!;
}
