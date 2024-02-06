using Microsoft.EntityFrameworkCore;
using TodoMigrations.Api.Db.Entities;
using TodoMigrations.Api.Db.Mappings;

namespace TodoMigrations.Api.Db
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todos> Todos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodosMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
