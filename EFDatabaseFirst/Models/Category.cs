using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDatabaseFirst.Models;

public partial class Category
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
