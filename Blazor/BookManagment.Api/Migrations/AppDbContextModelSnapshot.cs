// <auto-generated />
using System;
using BookManagment.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookManagment.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookManagment.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "amet@gmail.com",
                            FirstName = "ipsum",
                            LastName = "sit",
                            PenName = "Lorem",
                            Rating = 0
                        },
                        new
                        {
                            Id = 2,
                            Email = "amet@gmail.com",
                            FirstName = "ipsum",
                            LastName = "sit",
                            PenName = "Lorem",
                            Rating = 0
                        },
                        new
                        {
                            Id = 3,
                            Email = "amet@gmail.com",
                            FirstName = "ipsum",
                            LastName = "sit",
                            PenName = "Lorem",
                            Rating = 0
                        },
                        new
                        {
                            Id = 4,
                            Email = "amet@gmail.com",
                            FirstName = "ipsum",
                            LastName = "sit",
                            PenName = "Lorem",
                            Rating = 0
                        },
                        new
                        {
                            Id = 5,
                            Email = "amet@gmail.com",
                            FirstName = "ipsum",
                            LastName = "sit",
                            PenName = "Lorem",
                            Rating = 0
                        });
                });

            modelBuilder.Entity("BookManagment.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "Lorem ipsum sit amet",
                            Rating = 0,
                            ReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pasaka"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "Lorem ipsum sit amet",
                            Rating = 0,
                            ReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pasaka1"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Description = "Lorem ipsum sit amet",
                            Rating = 0,
                            ReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pasaka2"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 3,
                            Description = "Lorem ipsum sit amet",
                            Rating = 0,
                            ReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pasaka3"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 3,
                            Description = "Lorem ipsum sit amet",
                            Rating = 0,
                            ReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pasaka4"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 4,
                            Description = "Lorem ipsum sit amet",
                            Rating = 0,
                            ReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pasaka5"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 2,
                            Description = "Lorem ipsum sit amet",
                            Rating = 0,
                            ReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pasaka6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
