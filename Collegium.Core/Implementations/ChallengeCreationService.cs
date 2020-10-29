using TP3.Core.Data.ChallengeCreation;
using TP3.Core.Data.Datatable;
using TP3.Core.Interfaces;
using TP3.Core.Mappings;
using TP3.Domain.Interfaces;

namespace TP3.Core.Implementations
{
    public class ChallengeCreationService : IChallengeCreationService
    {
        private readonly IChallengeRepository _challengeRepository;

        public ChallengeCreationService(IChallengeRepository challengeRepository)
        {
            _challengeRepository = challengeRepository;
        }

        /// <summary>
        /// Get all Challenges by user base on filters
        /// </summary>
        /// <returns></returns>
        public GridData<ChallengeCreationGridData> GetAll(DTParameters param, string user)
        {
            return _challengeRepository.GetFilteredByPage(param.Start,
                        param.Length,
                        param.Search.Value,
                        param.Columns[param.Order[0].Column].Data,
                        param.Order[0].Dir.ToString(),
                        user).MapToGridData();
        }
    }
}
