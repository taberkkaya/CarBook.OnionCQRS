using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmetlerimiz";
            ViewBag.v2 = "Hizmetlerimiz";
            return View();
        }
    }
}
