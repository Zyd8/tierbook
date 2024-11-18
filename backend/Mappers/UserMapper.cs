using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos;
using backend.Dtos.User;
using backend.Models;

namespace backend.Mappers
{
    public static class UserMapper
    {
        public static UserDto ToUserDto(this UserModel userModel)
        {
            return new UserDto
            {
                Id = userModel.Id,
                Email = userModel.Email,
                Password = userModel.Password
            };
        }

        public static UserModel ToUserModelFromCreateDto(this CreateUserRequestDto userDto)
        {
            return new UserModel
            {
                Email = userDto.Email,
                Password = userDto.Password
            };
        }
    }
}