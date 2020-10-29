using TP3.Core.Data.BaseData;
using TP3.Domain.Entities;

namespace TP3.Core.Interfaces
{
    public interface IUserService
    {
        ResponseData Create(Data.Account.LoginData data);
        Data.User.UserEditData GetByUserName(string userName);
        ResponseData UpdatePassword(Data.User.UserEditData data);
    }
}
