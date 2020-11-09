using System.ComponentModel.DataAnnotations;

namespace TP3.Core.Data.Challenge
{
    public class CommandCableData
    {
        public CommandCableData()
        {
            IsSelect = true;
        }
        public int CommandId { get; set; }
        [Display(Name = "Comando")]
        public string Name { get; set; }
        public bool IsSelect { get; set; }
    }
}
