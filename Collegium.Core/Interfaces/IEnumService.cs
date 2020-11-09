using System.Collections.Generic;
using TP3.Core.Data.BaseData;
using TP3.Core.Data.Challenge;

namespace TP3.Core.Interfaces
{
    public interface IEnumService
    {
        List<CableData> GetAllCableSelectable();
        List<SelectableData> GetNetTypes();
        List<SelectableData> GetConnectionTypes();
        List<SelectableData> GetElements();
        List<SelectableData> GetCables();
        List<SelectableData> GetCommands();

    }
}
