namespace TaskManagementSystem.Model
{
    public class TaskHistory
    {
        public Guid Id { get; set; }
        public int TaskId { get; set; }
        public string Action { get; set; }
        public User ChangedBy { get; set; }
        public DateTime ChangedAt { get; set; }

    }
}
