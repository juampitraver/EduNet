using System.ComponentModel.DataAnnotations;
using TP3.Core.Data.BaseData;

namespace TP3.Core.Data.ChallengeCreation
{
    public class ChallengeCreationGridData:BaseGridData
    {
        public long Id { get; set; }
        [Display(Name = "Título")]
        public string Title { get; set; }
        [Display(Name = "Participantes")]
        public int Participants { get; set; }
        [Display(Name = "Código")]
        public string Code { get; set; }
        [Display(Name = "Último ingreso")]
        public string LastEntry { get; set; }
    }
}
