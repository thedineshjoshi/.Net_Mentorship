namespace TaskManagementSystem.Model
{
    public class TaskHistory
    {
        public Guid Id { get; set; }
        public string Action { get; set; } 
        public DateTime ChangedAt { get; set; }
        public Guid TaskId { get; set; }
        public New_Task Task { get; set; }
        public Guid ChangedByUserId { get; set; }
        public User ChangedBy { get; set; }

    }
}
