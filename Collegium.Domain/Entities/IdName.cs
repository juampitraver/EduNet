using System.ComponentModel.DataAnnotations;

namespace TP3.Domain.Entities
{
    public class IdName
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
