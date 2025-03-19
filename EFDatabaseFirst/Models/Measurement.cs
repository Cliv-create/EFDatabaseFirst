using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models;

public partial class Measurement
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
