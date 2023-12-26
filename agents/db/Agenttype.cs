using System;
using System.Collections.Generic;

namespace agents.db;

public partial class Agenttype
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<Agent> Agents { get; } = new List<Agent>();
}
