using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TP3.Domain.Entities
{
    public enum eConectionType : short
    {
        [Display(Name = "Directa")]
        [Description("Directa")]
        Direct = 1,
        [Display(Name = "Cruzada")]
        [Description("Cruzada")]
        Cross = 2
    }
}