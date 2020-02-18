using System.ComponentModel.DataAnnotations;
namespace Website.Models
{
    public class ProjectModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Desc { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }
    }
}