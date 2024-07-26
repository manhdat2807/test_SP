using System;
using System.Collections.Generic;

namespace DALtestSP.DAL_dat;

public partial class Kichco
{
    public string MaSize { get; set; } = null!;

    public double Kichco1 { get; set; }

    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
