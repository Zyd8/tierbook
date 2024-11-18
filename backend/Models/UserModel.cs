using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace backend.Models
{
    public class UserModel
    {
        public int Id { get; set; } 
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}