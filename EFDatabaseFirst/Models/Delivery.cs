using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDatabaseFirst.Models;

public partial class Delivery
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Product's ID is required")]
    public int? IdProduct { get; set; }

    [Required(ErrorMessage = "Supplier's ID is required")]
    public int? IdSupplier { get; set; }

    [Required(ErrorMessage = "Price is required")]
    public double? Price { get; set; }

    [Required(ErrorMessage = "Quantity is required")]
    public int? Quantity { get; set; }

    [Required(ErrorMessage = "Date of delivery is required")]
    public DateOnly? DateOfDelivery { get; set; }

    public virtual Product? IdProductNavigation { get; set; }

    public virtual Supplier? IdSupplierNavigation { get; set; }
}
