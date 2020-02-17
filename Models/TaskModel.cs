using System.ComponentModel.DataAnnotations;
namespace Website.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string TaskName
        public int ProjectId
        public int UserId
        public string TaskDescription
        public int StartDate
        public int DueDate
        public int Flags { get; set; } //0-100 or -2 = stuck etc?
        public string Comments
    }
}