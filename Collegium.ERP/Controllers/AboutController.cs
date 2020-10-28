using Microsoft.AspNetCore.Mvc;

namespace TP3.ERP.Controllers
{
    public class AboutController : Controller
    {
        public AboutController()
        {
        }

        public IActionResult Index() => View();
    }
}