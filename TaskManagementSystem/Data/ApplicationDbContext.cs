using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Model;

namespace TaskManagementSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        public DbSet<User>Users { get; set; }    
        public DbSet<Comment>Comments { get; set; }
        public DbSet<Label>Labels { get; set; } 
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Model.Task> Tasks { get; set; }
        public DbSet<TaskHistory> TaskHistories { get; set; }
        public DbSet<Model.TaskStatus> TaskStatus { get; set; }

    }
}
