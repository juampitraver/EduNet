using TP3.Core.Resources;
using System.ComponentModel.DataAnnotations;

namespace TP3.Core.Data.User
{
    public class UserData
    {
        public long Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [StringLength(100, MinimumLength = 8, ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "MaxLenth")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        [Display(Name = "Repetir Contraseña")]
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Compare")]
        public string  RepeatPassword { get; set; }
        [Display(Name = "Rol")]
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        public long RoleId { get; set; }
    }
}
