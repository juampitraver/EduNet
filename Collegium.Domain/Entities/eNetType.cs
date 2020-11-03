using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TP3.Domain.Entities
{
    public enum eNetType : short
    {
        [Display(Name = "LAN")]
        [Description("LAN")]
        LAN = 1,
        [Display(Name = "MAN")]
        [Description("MAN")]
        MAN = 2,
        [Display(Name = "WAN")]
        [Description("WAN")]
        WAN = 3,
        [Display(Name = "VPN")]
        [Description("VPN")]
        VPN = 4,
        [Display(Name = "Bluetooth")]
        [Description("BLUETOOTH")]
        BLUETOOTH = 5
    }
}