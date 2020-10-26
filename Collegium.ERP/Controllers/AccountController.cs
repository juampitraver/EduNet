using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using TP3.Core.Data.Account;
using TP3.Core.Interfaces;
using TP3.ERP.Helper;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TP3.ERP.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IAuthorizationService _authorizationService;

        public AccountController(IAccountService accountService,
                                 IAuthorizationService authorizationService)
        {
            _accountService = accountService;
            _authorizationService = authorizationService;
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();            
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginData data)
        {
            ModelState.Remove("RepeatPassword");
            ModelState.Remove("Name");
            if (ModelState.IsValid)
            {
                if (_accountService.Login(data))
                {
                    // Create the identity from the user info
                    var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, data.Email));
                    identity.AddClaim(new Claim(ClaimTypes.Name, data.Email));
                    // Authenticate using the identity
                    var principal = new ClaimsPrincipal(identity);
                    var authProperties = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.UtcNow.AddDays(1)
                    };
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authProperties);
                   
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}