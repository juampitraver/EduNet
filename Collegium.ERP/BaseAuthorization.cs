using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace TP3.ERP
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class BaseAuthorization : Attribute, IAuthorizationFilter
    {
        public BaseAuthorization()
        {

        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new RedirectToActionResult("Index", "ChallengeCode", null);
            }
            else
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }
}
