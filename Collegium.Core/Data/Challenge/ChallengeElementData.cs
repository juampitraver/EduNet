using System.ComponentModel.DataAnnotations;

namespace TP3.Core.Data.Challenge
{
    public class ChallengeElementData
    {
        public int ElementId { get; set; }
        [Display(Name = "Elemento")]
        public string Name { get; set; }
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }
        public bool IsSelect { get; set; }
    }
}
