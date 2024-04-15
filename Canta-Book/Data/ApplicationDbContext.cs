using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Canta_Book.Models;


namespace Canta_Book.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookCategory> BookCategory { get; set; }
        public DbSet<BookReader> BookReader { get; set; }
        public DbSet<User> User { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Author>()
        //        .HasKey(p => p.AuthorID);

        //    modelBuilder.Entity<Book>()
        //        .HasKey(p => p.BookID);

        //    modelBuilder.Entity<BookCategory>()
        //        .HasKey(p => p.CategoryID);

        //    modelBuilder.Entity<BookReader>()
        //        .HasKey(p => p.BookReaderID);

        //    modelBuilder.Entity<BookReader>()
        //        .HasOne(p => p.Book);

        //    modelBuilder.Entity<User>()
        //        .HasKey(p => p.UserID);
        //}
    }
}
