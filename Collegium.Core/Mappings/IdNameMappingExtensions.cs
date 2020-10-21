using TP3.Core.Data.BaseData;
using TP3.Domain.Entities;

namespace TP3.Core.Mappings
{
    public static class IdNameMappingExtensions
    {
        public static SelectableData MapToSelectableData(this IdName entity)
        {
            return new SelectableData
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}
