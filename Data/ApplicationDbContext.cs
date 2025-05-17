using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TaskX.Models;

namespace TaskX.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<TodoTask> TodoTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TodoTask>().HasData(
                new TodoTask { Id = 1, Title = "Task 1", Description = "Description 1", Bookmarked = false, CreatedAt = new DateTime(2025, 06, 05) },
                new TodoTask { Id = 2, Title = "Task 2", Description = "Description 2", Bookmarked = true, CreatedAt = new DateTime(2025, 06, 05) }
             );
        }
    }
}
