using System.ComponentModel.DataAnnotations;

namespace TP3.Domain.Entities
{
    public class User : IsActivable
    {
        public User()
        {
            IsActive = true;
        }
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public eRole Role { get; set; }
    }
}
