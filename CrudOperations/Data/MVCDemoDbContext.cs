using CrudOperations.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CrudOperations.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
