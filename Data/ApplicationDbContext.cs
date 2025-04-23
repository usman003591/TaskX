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
    }
}
