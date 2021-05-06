using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManagment.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PenName", "Rating" },
                values: new object[,]
                {
                    { 1, "amet@gmail.com", "ipsum", "sit", "Lorem", 0 },
                    { 2, "amet@gmail.com", "ipsum", "sit", "Lorem", 0 },
                    { 3, "amet@gmail.com", "ipsum", "sit", "Lorem", 0 },
                    { 4, "amet@gmail.com", "ipsum", "sit", "Lorem", 0 },
                    { 5, "amet@gmail.com", "ipsum", "sit", "Lorem", 0 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum sit amet", 0, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasaka" },
                    { 2, 1, "Lorem ipsum sit amet", 0, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasaka1" },
                    { 3, 2, "Lorem ipsum sit amet", 0, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasaka2" },
                    { 4, 3, "Lorem ipsum sit amet", 0, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasaka3" },
                    { 5, 3, "Lorem ipsum sit amet", 0, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasaka4" },
                    { 6, 4, "Lorem ipsum sit amet", 0, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasaka5" },
                    { 7, 2, "Lorem ipsum sit amet", 0, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasaka6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
