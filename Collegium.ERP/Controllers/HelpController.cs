using Microsoft.AspNetCore.Mvc;

namespace TP3.ERP.Controllers
{
    public class HelpController : Controller
    {
        public HelpController()
        {
        }

        public IActionResult Index() => View();
    }
}