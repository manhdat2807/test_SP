using System;
using System.Collections.Generic;

namespace DALtestSP.DAL_dat;

public partial class Ctsp
{
    public string MaCtsp { get; set; } = null!;

    public string MaTh { get; set; } = null!;

    public string MaSize { get; set; } = null!;

    public string MaMs { get; set; } = null!;

    public string MaSp { get; set; } = null!;

    public string MaXx { get; set; } = null!;

    public virtual Mausac MaMsNavigation { get; set; } = null!;

    public virtual Kichco MaSizeNavigation { get; set; } = null!;

    public virtual Sanpham MaSpNavigation { get; set; } = null!;

    public virtual Thuonghieu MaThNavigation { get; set; } = null!;

    public virtual Xuatxu MaXxNavigation { get; set; } = null!;
}
