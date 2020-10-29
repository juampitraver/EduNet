using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace TP3.ERP.Controllers.Authorization
{
    public class AuthorizationController : Controller
    {
        private readonly Core.Interfaces.IAuthorizationService _authorizationService;

        public AuthorizationController(Core.Interfaces.IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new RedirectToActionResult("Login", "Account", null);
            }
            else
            {
                var controllerActionDescriptor = context.ActionDescriptor as ControllerActionDescriptor;
                if (!controllerActionDescriptor.FilterDescriptors.Any(a => a.Filter.GetType() == typeof(AllowAnonymousFilter)))
                {
                    if (!_authorizationService.IsTeacher(context.HttpContext.User.Identity.Name))
                    {
                        context.Result = new RedirectToActionResult("Login", "Account", null);
                    }
                }
            }
            base.OnActionExecuting(context);
        }
    }
}