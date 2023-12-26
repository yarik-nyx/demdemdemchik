﻿using System;
using System.Collections.Generic;

namespace agents.db;

public partial class Shop
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Address { get; set; }

    public int Agentid { get; set; }

    public virtual Agent Agent { get; set; } = null!;
}
