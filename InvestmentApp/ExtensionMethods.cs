using InvestmentApp.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApp
{
    public static class ExtensionMethods
    {
        public static UserDto CastUserTableToUserDto(this UserTable user)
        {
            return new UserDto
            {
                ID = user.ID,
                Name = user.Name,
                Surname = user.Surname,
                Username = user.Username,
                Password = user.Password,
                RegisterDate = user.RegisterDate,
                Permission = user.Permission,
            };
        }
        public static UserTable CastUserDtoToUserTable(this UserDto user)
        {
            return new UserTable
            {
                ID = user.ID,
                Name = user.Name,
                Surname = user.Surname,
                Username = user.Username,
                Password = user.Password,
                RegisterDate = user.RegisterDate,
                Permission = user.Permission
            };
        }
    }
}
