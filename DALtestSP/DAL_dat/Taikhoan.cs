using System;
using System.Collections.Generic;

namespace DALtestSP.DAL_dat;

public partial class Taikhoan
{
    public string MaTk { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Passwords { get; set; } = null!;

    public bool? Trangthai { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
