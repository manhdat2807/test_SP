using System;
using System.Collections.Generic;

namespace DALtestSP.DAL_dat;

public partial class Thuonghieu
{
    public string MaTh { get; set; } = null!;

    public string TenTh { get; set; } = null!;

    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
