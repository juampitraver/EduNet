using TP3.Core.Data.Challenge;
using TP3.Domain.Entities;

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
    }
}