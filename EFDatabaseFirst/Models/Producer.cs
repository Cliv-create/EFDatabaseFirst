using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDatabaseFirst.Models;

public partial class Producer
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }

    public int? IdAddress { get; set; }

    public virtual Address? IdAddressNavigation { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
