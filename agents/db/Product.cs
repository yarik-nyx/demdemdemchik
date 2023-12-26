using System;
using System.Collections.Generic;

namespace agents.db;

public partial class Product
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Producttypeid { get; set; }

    public string? Articlenumber { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public int? Productionpersoncount { get; set; }

    public int? Productionworkshopnumber { get; set; }

    public decimal Mincostforagent { get; set; }

    public virtual ICollection<Productcosthistory> Productcosthistories { get; } = new List<Productcosthistory>();

    public virtual ICollection<Productmaterial> Productmaterials { get; } = new List<Productmaterial>();

    public virtual ICollection<Productsale> Productsales { get; } = new List<Productsale>();

    public virtual Producttype? Producttype { get; set; }
}
