using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TP3.Core.Data.BaseData;
using TP3.Core.Resources;

namespace TP3.Core.Data.Challenge
{
    public class ChallengeData
    {
        public ChallengeData()
        {
            Elements = new List<ChallengeElementData>();
            Cables = new List<ChallenteCableData>();
            Commands = new List<SelectableData>();
        }
        public long Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [Display(Name = "Descripción del desafio")]
        public string Description { get; set; }
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [Display(Name = "Título")]
        public string Title { get; set; }
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [Display(Name = "Tipo de conexión")]
        public int ConnectionTypeId { get; set; }
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = "Requeried")]
        [Display(Name = "Tipo de red")]
        public int NetTypeId { get; set; }
        [Display(Name = "Elementos")]
        public List<ChallengeElementData> Elements { get; set; }
        [Display(Name = "Elemento")]
        public int? ElementId { get; set; }
        [Display(Name = "Cantidad")]
        public int? Quantity { get; set; }
        [Display(Name = "Cables")]
        public List<ChallenteCableData> Cables { get; set; }
        [Display(Name = "Cable")]
        public int? CableId { get; set; }
        [Display(Name = "Orden")]
        public int? Order { get; set; }
        [Display(Name = "Comandos")]
        public List<SelectableData> Commands { get; set; }
        [Display(Name = "Commando")]
        public long? Command { get; set; }
    }
}
