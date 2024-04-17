using Microsoft.EntityFrameworkCore;
using Canta_Book.Models;


namespace Canta_Book.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<BookReader> BookReader { get; set; } = default!;

    }
}
