﻿using System;
using System.Collections.Generic;

namespace agents.db;

public partial class Producttype
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public double? Defectedpercent { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
