using Microsoft.AspNetCore.Mvc;
using TP3.Core.Data.Account;
using TP3.Core.Data.Datatable;
using TP3.Core.Data.User;
using TP3.Core.Interfaces;
using TP3.ERP.Helper;

namespace TP3.ERP.Controllers
{
    public class ChallengeController : Controller
    {
        private readonly IUserService _userService;

        public ChallengeController(IUserService userService)
        {
            _userService = userService;
        }       

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LoginData data)
        {
            if (ModelState.IsValid)
            {
                TempData.Put("RESPONSE", _userService.Create(data));
                return RedirectToAction("Login", "Account");
            }
            return View(data);
        }
    }
}