using System.ComponentModel.DataAnnotations;

namespace TP3.Core.Data.BaseData
{
    public class BaseGridData
    {
        [Display(Name = "Acciones")]
        public string Actions { get; set; }
    }
}
