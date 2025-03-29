using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDatabaseFirst.Models;

public partial class User
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name can not be more then 100 symbols")]
    public string? Name { get; set; }

    [Range(0, 120, ErrorMessage = "Age must be in range of 0 to 120")]
    public int Age { get; set; }
}
