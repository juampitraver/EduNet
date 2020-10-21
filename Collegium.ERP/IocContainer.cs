
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TP3.Core.Implementations;
using TP3.Core.Interfaces;
using TP3.Domain.Interfaces;
using TP3.Infrastructure;
using TP3.Infrastructure.Implementations;

namespace TP3.ERP
{
    public static class IocContainer
    {
        public static void AddIoc(this IServiceCollection iocService, string conectionString)
        {

            iocService.AddDbContext<Context>(options => options.UseSqlServer(conectionString));
            #region Services
            iocService.AddTransient<IAccountService, AccountService>();
            iocService.AddTransient<IAuthorizationService, AuthorizationService>();
            iocService.AddTransient<IUserService, UserService>();
            #endregion

            #region Repositories
            iocService.AddTransient<IUserRepository, UserRepository>();
            #endregion
        }
    }
}
