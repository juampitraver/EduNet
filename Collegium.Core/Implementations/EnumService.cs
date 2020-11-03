using System;
using System.Collections.Generic;
using System.Linq;
using TP3.Core.Data.Challenge;
using TP3.Core.Interfaces;
using TP3.Domain.Entities;

namespace TP3.Core.Implementations
{
    public class EnumService : IEnumService
    {
        public List<CableData> GetAllCableSelectable()
        {
            return Enum.GetValues(typeof(eCableColor)).Cast<eCableColor>().Select(s => new CableData
            {
                Id = (int)s,
                IsSelected = false,
                Order = (int)s
            }).ToList();

        }
    }
}
