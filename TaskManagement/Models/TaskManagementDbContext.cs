using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Models
{
    public class TaskManagementDbContext : DbContext
    {
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Task> Tasks { get; set; }
    }
}
