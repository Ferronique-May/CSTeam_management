using Microsoft.EntityFrameworkCore;

namespace Website.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> People { get; set; }

    }
}