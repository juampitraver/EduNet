using TP3.Core.Resources;
using System.ComponentModel.DataAnnotations;

namespace TP3.Core.Data.Challenge
{
    public class StartData
    {
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        
        [EmailAddress(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Email")]
        [Display(Name = "Mail")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [Display(Name = "Código del Desafío")]
        public string Code { get; set; }        
    }
}