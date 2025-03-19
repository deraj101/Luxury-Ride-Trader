// Data/ProductRepository.cs
#nullable enable
using LuxuryRideTrader.Models;
using System.Collections.Generic;
using System.Linq;

namespace LuxuryRideTrader.Data
{
    public static class ProductRepository
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "2018 Toyota Wigo ", Description = "Brand New", Price = 438000, ImageUrl = "/Image/toyotawigo.png", Category = "Toyota" },
            new Product { Id = 2, Name = "2016 Honda Odyssey", Description = "Second Hand", Price = 758000, ImageUrl = "/Image/hondaodyssy.png", Category = "Honda" },
            new Product { Id = 3, Name = "2010 Toyota Camry", Description = "Brand New", Price = 458000, ImageUrl = "/Image/toyotacamry.png", Category = "Toyota" },
            new Product { Id = 4, Name = "2021 Toyota Hilux", Description = "Second Hand", Price = 1200000, ImageUrl = "/Image/toyotahilux.png", Category = "Toyota" },
            new Product { Id = 5, Name = "2015 Toyota Fortuner", Description = "Brand New", Price = 1300000, ImageUrl = "/Image/toyotafurtuner.png", Category = "Toyota" },
            new Product { Id = 6, Name = "2021 Honda HR-V", Description = "Brand New", Price = 1300000, ImageUrl = "/Image/hondahr-v.png", Category = "Honda" },
            new Product { Id = 7, Name = "2021 Toyota Vios", Description = "Second Hand", Price = 890000, ImageUrl = "/Image/toyotavios.png", Category = "Toyota" },
            new Product { Id = 8, Name = "2018 Honda Civic", Description = "Second Hand", Price = 900000, ImageUrl = "/Image/hondacivic.png", Category = "Honda" },


        };

        public static List<Product> GetProducts(string? category = null)
        {
            if (string.IsNullOrEmpty(category))
                return products;

            return products.Where(p => p.Category == category).ToList();
        }
    }
}