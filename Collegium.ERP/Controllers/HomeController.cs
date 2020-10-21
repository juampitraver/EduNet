using Microsoft.AspNetCore.Mvc;
using TP3.ERP.Controllers.Authorization;
using IAuthorizationService = TP3.Core.Interfaces.IAuthorizationService;

namespace TP3.ERP.Controllers
{
    public class HomeController : AuthorizationController
    {
        public HomeController(IAuthorizationService authorizationService) : base(authorizationService)
        {
          
        }
        public IActionResult Index() => View();
    }
}