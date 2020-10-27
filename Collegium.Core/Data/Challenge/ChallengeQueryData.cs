using TP3.Core.Resources;
using System.ComponentModel.DataAnnotations;

namespace TP3.Core.Data.Challenge
{
    public class ChallengeQueryData
    {
        public long Id { get; set; }        
        
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Código")]
        public string Code { get; set; }
    }
}   