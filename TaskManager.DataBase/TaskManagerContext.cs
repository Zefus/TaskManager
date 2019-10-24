using TaskManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace TaskManager.DataBase
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .Property(p => p.CreateDate)
                .HasColumnType("datetime2");

            modelBuilder.Entity<Task>()
                .Property(p => p.CompleteDate)
                .HasColumnType("datetime2");
                
        }
    }
}
