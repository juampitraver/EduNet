using System.Linq;
using TP3.Core.Interfaces;
using TP3.Domain.Entities;
using TP3.Domain.Interfaces;

namespace TP3.Core.Implementations
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly IUserRepository _userRepository;

        public AuthorizationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool IsTeacher(string user)
        {
            return _userRepository.FindByCondition(f => f.Email.ToUpper().Trim().Equals(user.ToUpper().Trim())).FirstOrDefault().Role == eRole.Teacher;
        }



    }
}
