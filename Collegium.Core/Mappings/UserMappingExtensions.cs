using TP3.Core.Data.Datatable;
using TP3.Core.Data.User;
using TP3.Domain.Entities;
using TP3.Domain.Entities.Datatable;
using System.Linq;
using TP3.Core.Data.Account;

namespace TP3.Core.Mappings
{
    public static class UserMappingExtensions
    {
        public static User MapToEntity(this LoginData data, string passWord)
        {
            return new User
            {
                Email = data.Email.Trim(),
                Name = data.Name,
                Role = eRole.Teacher,
                Password = passWord
            };
        }

    
       
        public static User MapToEntity(this User entity, UserEditData data)
        {
            return entity;
        }
        public static UserEditData MapToData(this User entity)
        {
            return new UserEditData
            {
                Id = entity.Id,
                UserName = entity.Email
            };
        }
    }
}
