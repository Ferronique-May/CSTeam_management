using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Website.Models
{

    public class UserModel
    {
        [Key] //sets itself on creation counting upwards
        public int UserId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Role { get; set; }

        public static bool EmailExists(string Email, MyDbContext _db)
        {
            var user = _db.Users.FirstOrDefault(p => p.Email == Email);
            if (user == null) return false;
            return true;
        }
    }
}