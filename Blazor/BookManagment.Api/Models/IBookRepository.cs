using BookManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagment.Api.Models
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBook(int Id);
        Task<Book> RateBook(Book book);
    }
}
