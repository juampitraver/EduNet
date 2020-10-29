using System.Linq;
using TP3.Core.Data.Challenge;
using TP3.Core.Data.Datatable;
using TP3.Domain.Entities;
using TP3.Domain.Entities.Datatable;

namespace TP3.Core.Mappings
{
    public static class ChallengeMappingExtensions
    {
        public static ChallengeQueryData MapToData(this Challenge entity)
        {
            return new ChallengeQueryData
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                Code = entity.Code
            };
        }

        public static GridData<ChallengeGridData> MapToGridData(this PagingResult<Challenge> entity)
        {
            return new GridData<ChallengeGridData>
            {
                Count = entity.Count,
                List = entity.Results.Select(x => x.MapToGridData()).ToList()
            };
        }

        public static ChallengeGridData MapToGridData(this Challenge entity)
        {
            return new ChallengeGridData
            {
                Id = entity.Id,
                Code = entity.Code,
                Title = entity.Title
            };
        }
    }
}