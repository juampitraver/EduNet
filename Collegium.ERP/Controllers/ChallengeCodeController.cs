using Microsoft.AspNetCore.Mvc;

namespace TP3.ERP.Controllers
{
    public class ChallengeCodeController : Controller
    {
        public ChallengeCodeController()
        {

        }
        public IActionResult Index() => View();
    }
}