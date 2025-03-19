// Models/Product.cs
using System.ComponentModel.DataAnnotations;

namespace LuxuryRideTrader.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        public required string ImageUrl { get; set; }

        public required string Category { get; set; }
    }
}