using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Org.OpenAPITools.Models;

namespace personal.Helpers
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }


        public DbSet<Employee> Employees { get; set; }

    }
}
