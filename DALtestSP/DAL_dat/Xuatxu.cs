using System;
using System.Collections.Generic;

namespace DALtestSP.DAL_dat;

public partial class Xuatxu
{
    public string MaXx { get; set; } = null!;

    public string TennoiXx { get; set; } = null!;

    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
