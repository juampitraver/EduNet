using TP3.Core.Data.BaseData;
using System;

namespace TP3.Core.Interfaces
{
    public interface IUserService
    {
        ResponseData Create(Data.Account.LoginData data);
        Data.User.UserEditData GetByUserName(string userName);
        ResponseData UpdatePassword(Data.User.UserEditData data);
    }
}
