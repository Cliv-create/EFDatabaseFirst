using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDatabaseFirst.Models;

public partial class Supplier
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Address is required")]
    public int? IdAddress { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual Address? IdAddressNavigation { get; set; }
}
