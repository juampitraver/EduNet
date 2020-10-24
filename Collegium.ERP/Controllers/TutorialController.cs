using Microsoft.AspNetCore.Mvc;

namespace TP3.ERP.Controllers
{
    public class TutorialController : Controller
    {
        public TutorialController()
        {
        }

        public IActionResult Index() => View();
    }
}