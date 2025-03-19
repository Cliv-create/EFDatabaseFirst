using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models;

public partial class Delivery
{
    public int Id { get; set; }

    public int? IdProduct { get; set; }

    public int? IdSupplier { get; set; }

    public double? Price { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? DateOfDelivery { get; set; }

    public virtual Product? IdProductNavigation { get; set; }

    public virtual Supplier? IdSupplierNavigation { get; set; }
}
