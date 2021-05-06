using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagment.Models;

namespace BookManagment.Api.Models
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly AppDbContext appDbContext;

        public AuthorRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Author> GetAuthors()
        {
            return appDbContext.Authors;
        }
    }
}
