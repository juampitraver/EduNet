using System.ComponentModel;

namespace TP3.Domain.Entities
{
    public enum eElement : short
    {
        [Description("Ficha RJ485")]
        RJ45CONNECTOR = 1,
        [Description("Cable UTP")]
        UTPCABLE = 2,
        [Description("Pinza crimpeadora")]
        RJ485GRIPPER = 3,
        [Description("Tijera")]
        SCISSORS = 4,
        [Description("Cable Coaxial")]
        COAXIALCABLE = 5,
        [Description("Cable de electricidad")]
        ELECTRICITYCABLE = 6,
        [Description("Cinta aisladora")]
        DUCTTAPE = 7,
        [Description("Pinza plana")]
        FLATGRIPPER = 8,
        [Description("Ficha de teléfono")]
        PHONECONNECTOR = 9
    }
}