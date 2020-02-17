using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Website.Models
{

    public class UserModel
    {
        [Key] //sets itself on creation counting upwards
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FullName { get; set; }
        public bool Role { get; set; }
    }
}