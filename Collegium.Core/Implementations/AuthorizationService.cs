using TP3.Core.Interfaces;
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




    }
}
