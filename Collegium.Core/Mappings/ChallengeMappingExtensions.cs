using System;
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
                Title = entity.Title,
                LastEntry = DateTime.Now.ToString("g"),
                Participants = 6
            };
        }

        public static Challenge MapToEntity(this ChallengeData data, User user, string code)
        {
            return new Challenge
            {
                Cables = data.Cables.Select(map => new ChallengeCable
                {
                    CableColor = (eCableColor)map.CableId,
                    Order = map.Order
                }).ToList(),
                Commands = data.Commands.Select(map => new ChallengeCommand
                {
                    Command = (eCommand)map.CommandId
                }).ToList(),
                ConectionType = (eConectionType)data.ConnectionTypeId,
                Description = data.Description,
                Elements = data.Elements.Select(map => new ChallengeElement
                {
                    Element = (eElement)map.ElementId,
                    Quantity = map.Quantity
                }).ToList(),
                NetType = (eNetType) data.NetTypeId,
                Title = data.Title,
                UserId = user.Id,
                Code = code
            };
        }
    }
}