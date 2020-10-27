using TP3.Core.Resources;
using System.ComponentModel.DataAnnotations;
using System;

namespace TP3.Core.Data.Challenge
{
    public class ResultData
    {
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
                
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [Display(Name = "Código del Desafío")]
        public string Code { get; set; }

        public DateTime TimeLimit { get; set; }


    }
}