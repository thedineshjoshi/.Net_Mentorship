using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace TaskManagementSystem.Model
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public enum Status { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid ProjectId { get; set; }
        //public List<Comments> Comments { get; set; }





    }
}
