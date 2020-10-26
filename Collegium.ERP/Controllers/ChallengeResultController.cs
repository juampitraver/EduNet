using Microsoft.AspNetCore.Mvc;
using TP3.Core.Data.Account;
using TP3.Core.Data.Datatable;
using TP3.Core.Data.User;
using TP3.Core.Interfaces;
using TP3.ERP.Helper;

namespace TP3.ERP.Controllers
{
    public class ChallengeResultController : Controller
    {
        private readonly IUserService _userService;

        public ChallengeResultController(IUserService userService)
        {
            _userService = userService;
        }       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Start()
        {
            return View();
        }
    }
}