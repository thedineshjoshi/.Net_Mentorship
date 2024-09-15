namespace TaskManagementSystem.Model
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid CreatedByUserId { get; set; }
        public User CreatedBy { get; set; }
        public ICollection<New_Task> Tasks { get; set; } 
        public ICollection<User> TeamMembers { get; set; }
    }
}
