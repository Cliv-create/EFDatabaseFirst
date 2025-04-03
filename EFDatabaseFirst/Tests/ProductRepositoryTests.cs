using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace EFDatabaseFirst.Tests
{
    [TestFixture]
    public class ProductRepositoryTests
    {
        private StoreDbContext? _context;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<DbContext>()
            .UseInMemoryDatabase("TestDatabase")
            .Options;

            _context = new StoreDbContext(options);
        }

        [Test]
        public void GetAllProducts_ShouldReturnProducts()
        {
            var product1 = new Product { Name = "Milk", Price = 10.50, IdMeasurement = 1, IdProducer = 1 };
            var product2 = new Product { Name = "Egg", Price = 1.50, IdMeasurement = 2, IdProducer = 2 };
            _context?.Products.AddRange(product1, product2);
            _context?.SaveChanges();

            var result = _context?.Products?.ToList();

            Assert.That(result?.Count, Is.EqualTo(2));
            Assert.That(result?[0].Name, Is.EqualTo("Milk"));
            Assert.That(result?[1].Name, Is.EqualTo("Egg"));

            Assert.That(result?[0].Price, Is.EqualTo(10.50));
            Assert.That(result?[1].Price, Is.EqualTo(1.50));
        }
    }
}
