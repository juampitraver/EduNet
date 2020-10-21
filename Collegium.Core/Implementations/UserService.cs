using Microsoft.EntityFrameworkCore;
using TP3.Core.Data.BaseData;
using TP3.Core.Data.Datatable;
using TP3.Core.Data.User;
using TP3.Core.Helpers;
using TP3.Core.Interfaces;
using TP3.Core.Mappings;
using TP3.Core.Resources;
using TP3.Domain.Interfaces;
using System.Linq;
using TP3.Core.Data.Account;

namespace TP3.Core.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private const string _entity = "El usuario";

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        /// <summary>
        /// Encrypt password and create new User
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public ResponseData Create(LoginData data)
        {
            //If user exist
            if (_userRepository.FindByCondition(x => x.Email == data.Email.Trim() && x.IsActive).Any())
            {
                return new ResponseData
                {
                    Result = false,
                    Message = "Ya existe un usuario con ese mismo nombre"
                };
            }
            _userRepository.Create(data.MapToEntity(CryptographyHelper.Encrypt(data.Password.Trim())));
            if (_userRepository.Save())
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

    
        /// <summary>
        /// Get User by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserEditData GetById(long id)
        {
            return _userRepository.FindByCondition(f => f.Id == id).FirstOrDefault().MapToData();
        }

        

        /// <summary>
        /// Get User by id for change password
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserEditData GetByUserName(string email)
        {
            return _userRepository.FindByCondition(f => f.Email == email).FirstOrDefault().MapToData();
        }

        /// <summary>
        /// Update Password and Role of user
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public ResponseData UpdatePassword(UserEditData data)
        {
            var entity = _userRepository.FindByCondition(f => f.Email == data.UserName).FirstOrDefault();
            entity.Password = CryptographyHelper.Encrypt(data.Password.Trim());
            _userRepository.Update(entity);
            if (_userRepository.Save())
            {
                return new ResponseData
                {
                    Result = true,
                    Message = string.Format(ResponseMessages.MsgEditSuccess, _entity)
                };
            }
            else
            {
                return new ResponseData
                {
                    Result = false,
                    Message = string.Format(ResponseMessages.MsgEditError, _entity)
                };
            }
        }
    }
}
