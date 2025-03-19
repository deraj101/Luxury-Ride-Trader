// Controllers/ProductController.cs
using LuxuryRideTrader.Data;
using Microsoft.AspNetCore.Mvc;

namespace LuxuryRideTrader.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index(string category)
        {
            ViewData["Title"] = string.IsNullOrEmpty(category) ? "All Cars" : category; // Set the title based on category
            var products = ProductRepository.GetProducts(category);
            return View(products);
        }
        

        
    }
}