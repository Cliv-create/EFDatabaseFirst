using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models;

public partial class Sale
{
    public int Id { get; set; }

    public int? IdProduct { get; set; }

    public double? Price { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? DateOfSale { get; set; }

    public virtual Product? IdProductNavigation { get; set; }
}
