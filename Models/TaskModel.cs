using System;
using System.ComponentModel.DataAnnotations;
namespace Website.Models
{
    public class TaskModel
    {
        [Key]
        public int TaskId { get; set; }
        [Required]
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }
        [Required]
        [Display(Name = "Task Description")]
        public string TaskDescription { get; set; }

        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy/mm/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy/mm/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

        [Required]
        [Display(Name = "Progress")]
        public int Progress { get; set; } // 0 - 100 

        [Required]
        [Display(Name = "Status")]
        public string Flags { get; set; } //In Progess, Stuck,  Complete?

        [Required]
        public string Comments { get; set; } // Provides reasons for the flags

        [Required]
        [Display(Name = "Project Name")]
        public int ProjectId { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public int UserId { get; set; }
    }
}