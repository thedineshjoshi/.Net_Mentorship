namespace TaskManagementSystem.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public enum Role { Admin, Manager, User}
        public DateTime CreatedAt { get; set; }
        public DateTime LastLogin { get; set; }
        public ICollection<New_Task> CreatedTasks { get; set; }
        public ICollection<New_Task> AssignedTasks { get; set; }
        public ICollection<Project> CreatedProjects { get; set; }
    }
}
