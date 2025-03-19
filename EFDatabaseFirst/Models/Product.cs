using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? IdCategory { get; set; }

    public double? Price { get; set; }

    public int? Quantity { get; set; }

    public int? IdProducer { get; set; }

    public int? IdMeasurement { get; set; }

    public int? IdMarkup { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual Category? IdCategoryNavigation { get; set; }

    public virtual Discount? IdMarkupNavigation { get; set; }

    public virtual Measurement? IdMeasurementNavigation { get; set; }

    public virtual Producer? IdProducerNavigation { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
