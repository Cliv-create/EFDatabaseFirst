using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDatabaseFirst.Models;

public partial class Product
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }

    public int? IdCategory { get; set; }

    [Required(ErrorMessage = "Price is required")]
    public double? Price { get; set; }

    public int? Quantity { get; set; }

    [Required(ErrorMessage = "Producer is required")]
    public int? IdProducer { get; set; }

    [Required(ErrorMessage = "Measurement is required")]
    public int? IdMeasurement { get; set; }

    public int? IdMarkup { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual Category? IdCategoryNavigation { get; set; }

    public virtual Discount? IdMarkupNavigation { get; set; }

    public virtual Measurement? IdMeasurementNavigation { get; set; }

    public virtual Producer? IdProducerNavigation { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
