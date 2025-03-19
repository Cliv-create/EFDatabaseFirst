using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models;

public partial class Address
{
    public int Id { get; set; }

    public string? Street { get; set; }

    public int? IdCity { get; set; }

    public virtual City? IdCityNavigation { get; set; }

    public virtual ICollection<Producer> Producers { get; set; } = new List<Producer>();

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
