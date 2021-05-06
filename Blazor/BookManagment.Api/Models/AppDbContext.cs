using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagment.Api.Models
{
    public class AppDbContext : DbContext { 
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Book data:
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                AuthorId = 1,
                Title = "Pasaka",
                Description = "Lorem ipsum sit amet",
                ReleaseDate = new DateTime(1900, 1, 1),
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                AuthorId = 1,
                Title = "Pasaka1",
                Description = "Lorem ipsum sit amet",
                ReleaseDate = new DateTime(1900, 1, 1),
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                AuthorId = 2,
                Title = "Pasaka2",
                Description = "Lorem ipsum sit amet",
                ReleaseDate = new DateTime(1900, 1, 1),
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 4,
                AuthorId = 3,
                Title = "Pasaka3",
                Description = "Lorem ipsum sit amet",
                ReleaseDate = new DateTime(1900, 1, 1),
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 5,
                AuthorId = 3,
                Title = "Pasaka4",
                Description = "Lorem ipsum sit amet",
                ReleaseDate = new DateTime(1900, 1, 1),
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 6,
                AuthorId = 4,
                Title = "Pasaka5",
                Description = "Lorem ipsum sit amet",
                ReleaseDate = new DateTime(1900, 1, 1),
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 7,
                AuthorId = 2,
                Title = "Pasaka6",
                Description = "Lorem ipsum sit amet",
                ReleaseDate = new DateTime(1900, 1, 1),
            });

            //Author data:
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 1,
                PenName = "Lorem",
                FirstName = "ipsum",
                LastName = "sit",
                Email = "amet@gmail.com"
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 2,
                PenName = "Lorem",
                FirstName = "ipsum",
                LastName = "sit",
                Email = "amet@gmail.com"
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 3,
                PenName = "Lorem",
                FirstName = "ipsum",
                LastName = "sit",
                Email = "amet@gmail.com"
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 4,
                PenName = "Lorem",
                FirstName = "ipsum",
                LastName = "sit",
                Email = "amet@gmail.com"
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 5,
                PenName = "Lorem",
                FirstName = "ipsum",
                LastName = "sit",
                Email = "amet@gmail.com"
            });
        }


    }
}
