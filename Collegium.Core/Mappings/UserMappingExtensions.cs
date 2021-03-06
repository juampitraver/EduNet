﻿using TP3.Core.Data.Account;
using TP3.Core.Data.User;
using TP3.Domain.Entities;

namespace TP3.Core.Mappings
{
    public static class UserMappingExtensions
    {
        public static User MapToEntity(this LoginData data, string password)
        {
            return new User
            {
                Email = data.Email.Trim(),
                Name = data.Name,
                Role = (eRole)data.Role,
                Password = password
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