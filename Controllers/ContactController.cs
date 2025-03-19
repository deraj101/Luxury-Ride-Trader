using Microsoft.AspNetCore.Mvc;

namespace LuxuryRideTrader.Controllers
{
    public class ContactController : Controller
    {
       public IActionResult Index()
{

    ViewData["Title"] = "Contact"; // Set the title for the Contact page

    return View();

}
    }
}