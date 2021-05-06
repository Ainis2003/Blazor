using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagment.Models;
using BookManagment.Web.Services;
using Microsoft.AspNetCore.Components;

namespace BookManagment.Web.Pages
{
    public class BookListBase : ComponentBase
    {
        [Inject]
        public IBookService BookService { get; set; }
        
        public IEnumerable<Book> Books { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Books = (await BookService.GetBooks()).ToList();
        }
    }
}
