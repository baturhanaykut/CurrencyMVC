using Microsoft.AspNetCore.Mvc;

namespace CurrencyMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
