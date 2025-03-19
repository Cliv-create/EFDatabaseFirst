using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models;

public partial class Producer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? IdAddress { get; set; }

    public virtual Address? IdAddressNavigation { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
