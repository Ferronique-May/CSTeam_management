
using System.ComponentModel.DataAnnotations;
namespace Website.Models
{
    public class Person
    {
        [Key] //sets itself on creation counting upwards
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Years { get; set; }
    }
}