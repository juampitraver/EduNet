using System.Linq;
using TP3.Core.Data.BaseData;
using TP3.Core.Data.Challenge;
using TP3.Core.Interfaces;
using TP3.Core.Mappings;
using TP3.Core.Resources;
using TP3.Domain.Interfaces;

namespace TP3.Core.Implementations
{
    public class ChallengeService: IChallengeService
    {
        private readonly IChallengeRepository _challengeRepository;
        private const string _entity = "El Desafío";

        public ChallengeService(IChallengeRepository challengeRepository)
        {
            _challengeRepository = challengeRepository;
        }

        public ResponseData ValidByCode(string code)
        {
            var challenge = _challengeRepository.FindByCondition(f => f.Code == code && f.IsActive).FirstOrDefault();
            if (challenge != null)
            {
                return new ResponseData
                {
                    Result = true,
                    Message = "El Desafío con el Código ya existe"
                };
            }
            return new ResponseData
            {
                Result = false,
                Message = "El Desafío con el Código no existe"
            };
        }

        public ChallengeQueryData GetByCode(string code)
        {
            var challenge = _challengeRepository.FindByCondition(f => f.Code == code && f.IsActive).FirstOrDefault();
            if (challenge != null)
            {
                return challenge.MapToData();
            }
            return null;
        }
    }
}