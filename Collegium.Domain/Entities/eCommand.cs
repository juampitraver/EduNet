using System.ComponentModel;

namespace TP3.Domain.Entities
{
    public enum eCommand : short
    {
        [Description("ping")]
        PING = 1,
        [Description("ipconfig")]
        IPCONFIG = 2,
        [Description("rmdir")]
        RMDIR = 3,
        [Description("timeout")]
        TIMEOUT = 4,
        [Description("erase")]
        ERASE = 5,
        [Description("mklink")]
        MKLINK = 6,
        [Description("setlocal")]
        SETLOCAL = 7,
        [Description("verify")]
        VERIFY = 8,
        [Description("reg")]
        REG = 9,
        [Description("net")]
        NET = 10,
    }
}
