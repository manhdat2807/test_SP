using System;
using System.Collections.Generic;

namespace DALtestSP.DAL_dat;

public partial class Hoadon
{
    public string MaHd { get; set; } = null!;

    public string Manv { get; set; } = null!;

    public DateTime Ngaymua { get; set; }

    public double Gia { get; set; }

    public string MaKm { get; set; } = null!;

    public double Thanhtien { get; set; }

    public virtual ICollection<Cthd> Cthds { get; set; } = new List<Cthd>();

    public virtual Khuyenmai MaKmNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
