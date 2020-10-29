using System.Linq;
using TP3.Core.Data.BaseData;
using TP3.Core.Data.Challenge;
using TP3.Core.Data.Datatable;
using TP3.Core.Interfaces;
using TP3.Core.Mappings;
using TP3.Core.Resources;
using TP3.Domain.Interfaces;

namespace TP3.Core.Implementations
{
    public class ChallengeService : IChallengeService
    {
        private readonly IChallengeRepository _challengeRepository;
        private readonly IUserRepository _userRepository;
        private const string _entity = "El Desafío";

        public ChallengeService(IChallengeRepository challengeRepository,
                                IUserRepository userRepository)
        {
            _challengeRepository = challengeRepository;
            _userRepository = userRepository;
        }


        /// <summary>
        /// Get all Challenges by user base on filters
        /// </summary>
        /// <returns></returns>
        public GridData<ChallengeGridData> GetAll(DTParameters param, string user)
        {
            return _challengeRepository.GetFilteredByPage(param.Start,
                        param.Length,
                        param.Search.Value,
                        param.Columns[param.Order[0].Column].Data,
                        param.Order[0].Dir.ToString(),
                        user).MapToGridData();
        }

        /// <summary>
        /// Create the challenge from user with role = teacher
        /// </summary>
        /// <param name="data"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public ResponseData Create(ChallengeData data, string userName)
        {
            var user = _userRepository.FindByCondition(f => f.Email.ToUpper().Trim().Equals(userName.ToUpper().Trim()) && f.IsActive && f.Role == Domain.Entities.eRole.Teacher).FirstOrDefault();
            if (user != null)
            {
                _challengeRepository.Create(data.MapToEntity(user));
                if (_challengeRepository.Save())
                {
                    return new ResponseData
                    {
                        Result = true,
                        Message = string.Format(ResponseMessages.MsgSaveSuccess, _entity)
                    };
                }
                else
                {
                    return new ResponseData
                    {
                        Result = false,
                        Message = string.Format(ResponseMessages.MsgSaveError, _entity)
                    };
                }
            }
            return new ResponseData
            {
                Result = false,
                Message = string.Format(ResponseMessages.MsgSaveError, _entity)
            };
        }

        public ResponseData ValidByCode(string code)
        {
            var challenge = _challengeRepository.FindByCondition(f => f.Code == code && f.IsActive).FirstOrDefault();
            if (challenge != null)
            {
                return new ResponseData
                {
                    Result = true,
                    Message = "El Desafío con el Código ingresado ya existe."
                };
            }
            return new ResponseData
            {
                Result = false,
                Message = "El Desafío con el Código ingresado no existe."
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