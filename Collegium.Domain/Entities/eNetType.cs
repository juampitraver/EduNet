using System.ComponentModel;

namespace TP3.Domain.Entities
{
    public enum eNetType : short
    {
        [Description("LAN")]
        LAN = 1,
        [Description("MAN")]
        MAN = 2,
        [Description("WAN")]
        WAN = 3,
        [Description("VPN")]
        VPN = 4,
        [Description("BLUETOOTH")]
        BLUETOOTH = 5
    }
}
