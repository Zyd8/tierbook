using System.ComponentModel.DataAnnotations;

namespace backend.Dtos.User
{
    public class UserDto
    {
        public int Id { get; set; } 
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
