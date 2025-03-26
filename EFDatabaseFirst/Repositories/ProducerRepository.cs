using EFDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDatabaseFirst.Repositories
{
    public class ProducerRepository
    {
        public List<Producer>? GetAllProducers()
        {
            using var context = new StoreDbContext();
            var producers = context.Producers
                .Include(p => p.IdAddressNavigation)
                .ToList();
            
            return producers;
        }

        public ProducerRepository AddProducer(Producer producer)
        {
            using var context = new StoreDbContext();
            var _producer = new Producer { 
                Id = producer.Id,
                Name = producer.Name,
                IdAddress = producer.IdAddress
            };

            context.Producers?.Add(_producer);
            context.SaveChanges();
            Console.WriteLine($"Producer {_producer.Name} was added!");

            return this;
        }

        public ProducerRepository UpdateProducer(int producer_id, Producer producer)
        {
            using var context = new StoreDbContext();

            // Attach the modified product
            producer.Id = producer_id; // Ensure ID is set correctly
            context.Producers.Update(producer);

            context.SaveChanges();
            
            return this;
        }

        public ProducerRepository DeleteProducer(int producer_id)
        {
            using var context = new StoreDbContext();
            var _producer = context.Producers?
                .FirstOrDefault(p => p.Id == producer_id);
            if (_producer == null)
            {
                Console.WriteLine($"Producer with ID {producer_id} was not found!");
                return this;
            }

            context.Producers?.Remove(_producer);
            context.SaveChanges();
            Console.WriteLine($"Producer with ID {producer_id} was deleted!");

            return this;
        }

        public List<Producer>? GetProducersWithProducts()
        {
            using var context = new StoreDbContext();

            var producers = context.Producers
                .Include(p => p.Products)
                .ToList();
            
            return producers;
        }

        public List<Producer>? GetProducersWithAddress()
        {
            using var context = new StoreDbContext();

            var producers = context.Producers
                .Include(p => p.IdAddressNavigation)
                .ToList();
            
            return producers;
        }

        public List<Producer>? GetProducersWithProductsAndAddress()
        {
            using var context = new StoreDbContext();

            var producers = context.Producers
                .Include(p => p.IdAddressNavigation)
                .Include(p => p.Products)
                .ToList();
            
            return producers;
        }
    }
}