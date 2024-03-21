using Microsoft.AspNetCore.Mvc;

namespace AplicacaoWeb.Views.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
