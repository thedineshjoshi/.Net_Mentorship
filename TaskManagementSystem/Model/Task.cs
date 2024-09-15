using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace TaskManagementSystem.Model
{
    public class New_Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public TaskPriority Priority { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Comment> Comments { get; set; } // Comments on this task
        public ICollection<TaskHistory> HistoryEntries { get; set; } // Task history entries
        public Guid CreatedByUserId { get; set; }
        public User CreatedBy { get; set; }
        public Guid AssignedToUserId { get; set; }
        public User AssignedTo { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
