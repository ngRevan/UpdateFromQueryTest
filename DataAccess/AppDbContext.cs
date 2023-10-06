using DataAccess.Models;
using System.Data.Entity;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(string connectionString) : base(connectionString)
        { }

        public DbSet<Test> Tests { get; set; }
    }
}
