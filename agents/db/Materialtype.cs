using System;
using System.Collections.Generic;

namespace agents.db;

public partial class Materialtype
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public double Defectedpercent { get; set; }

    public virtual ICollection<Material> Materials { get; } = new List<Material>();
}
