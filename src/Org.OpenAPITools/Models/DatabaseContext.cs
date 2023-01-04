using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Models
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Assignment> Assignments { get; set; }
         public DbSet<Employee> employees { get; set; }

    }
}