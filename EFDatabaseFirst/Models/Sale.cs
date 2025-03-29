using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDatabaseFirst.Models;

public partial class Sale
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Product's ID is required")]
    public int? IdProduct { get; set; }

    public double? Price { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? DateOfSale { get; set; }

    public virtual Product? IdProductNavigation { get; set; }
}
