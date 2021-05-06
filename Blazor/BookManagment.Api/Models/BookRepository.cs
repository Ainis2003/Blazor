using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagment.Api.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Book> GetBook(int Id)
        {
            return await appDbContext.Books.FirstOrDefaultAsync(b => b.Id == Id);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await appDbContext.Books.ToListAsync();
        }

        public async Task<Book> RateBook(Book book)
        {
            var result = await appDbContext.Books.FirstOrDefaultAsync(b => b.Rating == book.Rating);

            if(result != null)
            {
                result.Rating = book.Rating;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
