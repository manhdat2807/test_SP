using System;
using System.Collections.Generic;

namespace DALtestSP.DAL_dat;

public partial class Nhanvien
{
    public string Manv { get; set; } = null!;

    public string Tennv { get; set; } = null!;

    public bool? Gioitinh { get; set; }

    public DateTime Ngaysinh { get; set; }

    public string Diachi { get; set; } = null!;

    public string Vaitro { get; set; } = null!;

    public string MaTk { get; set; } = null!;

    public virtual ICollection<Cthd> Cthds { get; set; } = new List<Cthd>();

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual Taikhoan MaTkNavigation { get; set; } = null!;
}
