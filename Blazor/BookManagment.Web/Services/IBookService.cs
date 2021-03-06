using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagment.Models;

namespace BookManagment.Web.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetBooks();
    }
}
