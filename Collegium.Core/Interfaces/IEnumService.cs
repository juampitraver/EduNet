using System.Collections.Generic;
using TP3.Core.Data.Challenge;

namespace TP3.Core.Interfaces
{
    public interface IEnumService
    {
        List<CableData> GetAllCableSelectable();
    }
}
