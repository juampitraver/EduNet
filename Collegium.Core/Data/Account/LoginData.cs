using TP3.Core.Resources;
using System.ComponentModel.DataAnnotations;

namespace TP3.Core.Data.Account
{
    public class LoginData
    {
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Email")]
        [Display(Name = "Mail")]
        public string Email { get; set; }
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Compare")]
        [Display(Name = "Contraseña")]
        public string RepeatPassword { get; set; }
    }
}
