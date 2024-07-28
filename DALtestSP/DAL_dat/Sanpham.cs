using System;
using System.Collections.Generic;

namespace DALtestSP.DAL_dat;

public partial class Sanpham
{
    public string Masp { get; set; } = null!;

    public string Tensp { get; set; } = null!;

    public double Gia { get; set; }

    public int Slton { get; set; }

    public bool? Trangthai { get; set; }= null!;

    public virtual ICollection<Cthd> Cthds { get; set; } = new List<Cthd>();

    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
