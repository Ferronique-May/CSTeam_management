using System.ComponentModel.DataAnnotations;
namespace Website.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TaskName { get; set; }
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string TaskDescription { get; set; }
        public int StartDate { get; set; }
        public int DueDate { get; set; }
        public int Flags { get; set; } //0-100 or -2 = stuck etc?
        public string Comments { get; set; }
    }
}