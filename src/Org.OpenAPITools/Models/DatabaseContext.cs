using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Org.OpenAPITools.Models;
using static Org.OpenAPITools.Models.Assignment;

namespace Org.OpenAPITools.Models
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) => NpgsqlConnection.GlobalTypeMapper.MapEnum<assignment_role>();
       

        protected override void OnModelCreating(ModelBuilder builder)
    => builder.HasPostgresEnum<assignment_role>();

        public DbSet<Assignment> assignments { get; set; }
        public DbSet<Employee> employees { get; set; }

    }
}