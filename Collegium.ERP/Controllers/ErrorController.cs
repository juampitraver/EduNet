using Microsoft.AspNetCore.Mvc;

namespace TP3.ERP.Controllers
{
    public class ErrorController : Controller
    {

        public IActionResult Error() => View();
        public IActionResult NotAllowed() => View();
    }
}