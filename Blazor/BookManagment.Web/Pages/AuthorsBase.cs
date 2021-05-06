using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagment.Models;
using Microsoft.AspNetCore.Components;

namespace BookManagment.Web.Pages
{
    public class AuthorsBase : ComponentBase
    {
        public IEnumerable<Author> Authors { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadBooks);
        }
        private void LoadBooks()
        {
            Author one = new Author
            {
                Id = 1,
                PenName = "Lorem",
                FirstName = "ipsum",
                LastName = "sit",
                Email = "amet@gmail.com"
            };

            Author two = new Author
            {
                Id = 2,
                PenName = "Lorem",
                FirstName = "ipsum",
                LastName = "sit",
                Email = "amet@gmail.com"
            };

            Author three = new Author
            {
                Id = 3,
                PenName = "Lorem",
                FirstName = "ipsum",
                LastName = "sit",
                Email = "amet@gmail.com"
            };

            Author four = new Author
            {
                Id = 4,
                PenName = "Lorem",
                FirstName = "ipsum",
                LastName = "sit",
                Email = "amet@gmail.com"
            };

            Author five = new Author
            {
                Id = 5,
                PenName = "Lorem",
                FirstName = "ipsum",
                LastName = "sit",
                Email = "amet@gmail.com"
            };

            Authors = new List<Author> { one, two, three, four, five};
        }
    }
}
