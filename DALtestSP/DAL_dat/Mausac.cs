using System;
using System.Collections.Generic;

namespace DALtestSP.DAL_dat;

public partial class Mausac
{
    public string MaMs { get; set; } = null!;

    public string TenMs { get; set; } = null!;

    public virtual ICollection<Ctsp> Ctsps { get; set; } = new List<Ctsp>();
}
