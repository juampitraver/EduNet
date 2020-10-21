using TP3.Core.Data.Account;
using TP3.Core.Helpers;
using TP3.Core.Interfaces;
using TP3.Domain.Interfaces;
using System.Linq;

namespace TP3.Core.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;

        public AccountService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Login(LoginData data)
        {
            return _userRepository.FindByCondition(f => f.IsActive && f.Email == data.Email && f.Password.Equals(CryptographyHelper.Encrypt(data.Password)) && f.Role == Domain.Entities.eRole.Teacher).Any();
        }
    }
}
