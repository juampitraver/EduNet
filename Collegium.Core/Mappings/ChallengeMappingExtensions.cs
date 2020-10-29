using System.Linq;
using TP3.Core.Data.ChallengeCreation;
using TP3.Core.Data.Datatable;
using TP3.Domain.Entities;
using TP3.Domain.Entities.Datatable;

namespace TP3.Core.Mappings
{
    public static class ChallengeMappingExtensions
    {
        public static GridData<ChallengeCreationGridData> MapToGridData(this PagingResult<Challenge> entity)
        {
            return new GridData<ChallengeCreationGridData>
            {
                Count = entity.Count,
                List = entity.Results.Select(x => x.MapToGridData()).ToList()
            };
        }

        public static ChallengeCreationGridData MapToGridData(this Challenge entity)
        {
            return new ChallengeCreationGridData
            {
                Id = entity.Id,
                Code = entity.Code,
                Title = entity.Title
            };
        }
    }
}
