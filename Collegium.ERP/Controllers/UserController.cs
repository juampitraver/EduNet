using Microsoft.AspNetCore.Mvc;
using TP3.Core.Data.Account;
using TP3.Core.Data.Datatable;
using TP3.Core.Data.User;
using TP3.Core.Interfaces;
using TP3.Domain.Entities;
using TP3.ERP.Helper;

namespace TP3.ERP.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
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
                data.Role = (byte)eRole.Teacher;
                TempData.Put("RESPONSE", _userService.Create(data));
                return RedirectToAction("Login", "Account");
            }
            return View(data);
        }        

        public IActionResult ChangePassword()
        {
            return View(_userService.GetByUserName(User.Identity.Name));
        }

        [HttpPost]
        public IActionResult ChangePassword(UserEditData data)
        {
            ModelState.Remove("UserName");
            data.UserName = User.Identity.Name;
            if (ModelState.IsValid)
            {
                TempData.Put("RESPONSE", _userService.UpdatePassword(data));
                return RedirectToAction("Index", "Home");
            }
            return View(data);
        }
    }
}