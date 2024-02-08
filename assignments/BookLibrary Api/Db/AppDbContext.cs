using BookLibrary_Api.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary_Api.Db
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
