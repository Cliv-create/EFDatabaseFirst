using EFDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using EFDatabaseFirst.Repositories;

namespace EFDatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (System.IO.File.Exists("config.json"))
                {
                    ConfigManager.LoadConfig();
                }
                else
                {
                    ConfigManager.GenerateInitialConfig();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Hello, World!");

            try
            {
                using (var context = new StoreDbContext())
                {
                    var products = context.Products?
                    .Include(p => p.IdCategoryNavigation)
                    .ToList();

                    if (!(products != null))
                        return;
                    
                    foreach (var product in products)
                    {
                        Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Category: {product.IdCategoryNavigation.Name}");
                    }
                }

                using (var context = new StoreDbContext())
                {
                    var producers = new ProducerRepository().GetProducersWithProducts();

                    if (!(producers != null))
                        return;
                    
                    foreach (var producer in producers)
                    {
                        Console.WriteLine($"ID: {producer.Id}, Name: {producer.Name}, Category: {producer.IdAddressNavigation.Street}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
