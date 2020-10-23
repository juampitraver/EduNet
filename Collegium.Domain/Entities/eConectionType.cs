using System.ComponentModel;

namespace TP3.Domain.Entities
{
    public enum eConectionType : short
    {
        [Description("Directa")]
        Direct = 1,
        [Description("Cruzada")]
        Cross = 2
    }
}
