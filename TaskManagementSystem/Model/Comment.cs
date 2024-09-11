namespace TaskManagementSystem.Model
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }

    }
}
