namespace TaskManagementSystem.Model
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid TaskId { get; set; }
        public New_Task Task { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
