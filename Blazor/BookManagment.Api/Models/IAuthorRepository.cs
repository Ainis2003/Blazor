using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagment.Models;

namespace BookManagment.Api.Models
{
    interface IAuthorRepository
    {
        IEnumerable<Author> GetAuthors();
    }
}
