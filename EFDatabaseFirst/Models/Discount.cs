using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models;

public partial class Discount
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Percent { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
