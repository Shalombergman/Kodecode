using System.Configuration;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MVCBooksSystem.Models;

namespace MVCBooksSystem.Data


{
    public class ApplicationDbContext : DbContext
    {

        //constractor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Shelv> Shelves { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookSet> BookSets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Genre>().
                HasMany(genre => genre.Libraries)
                .WithOne(library => library.Genre)
                .HasForeignKey(library => library.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelbuilder.Entity<Genre>().
              HasMany(genre => genre.Books)
              .WithOne(book => book.Genre)
              .HasForeignKey(book => book.GenreId)
              .OnDelete(DeleteBehavior.Restrict);

            modelbuilder.Entity<Library>().
                HasMany(library => library.Shelves)
                .WithOne(shelv => shelv.Library)
                .HasForeignKey(shelv => shelv.LibraryId)
                .OnDelete(DeleteBehavior.Cascade);


            modelbuilder.Entity<Shelv>().
                HasMany(shelv => shelv.Books)
                .WithOne(Book => Book.Shelv)
                .HasForeignKey(Book => Book.ShelvId)
                .OnDelete(DeleteBehavior.SetNull);

            modelbuilder.Entity<BookSet>().
              HasMany(bookSet => bookSet.Books)
              .WithOne(book => book.BookSet)
              .HasForeignKey(book => book.SetId)
              .OnDelete(DeleteBehavior.Cascade);

            

        }
            
        
            
                
            
        





    }

}
