using System;
using System.Collections.Generic;

namespace agents.db;

public partial class Agent
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int Agenttypeid { get; set; }

    public string? Address { get; set; }

    public string Inn { get; set; } = null!;

    public string? Kpp { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Logo { get; set; }

    public int Priority { get; set; }

    public string Dirsurname { get; set; } = null!;

    public string Dirname { get; set; } = null!;

    public string Dirpatr { get; set; } = null!;

    public virtual ICollection<Agentpriorityhistory> Agentpriorityhistories { get; } = new List<Agentpriorityhistory>();

    public virtual Agenttype Agenttype { get; set; } = null!;

    public virtual ICollection<Productsale> Productsales { get; } = new List<Productsale>();

    public virtual ICollection<Shop> Shops { get; } = new List<Shop>();
}
