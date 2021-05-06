using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BookManagment.Models;
using Microsoft.AspNetCore.Components;

namespace BookManagment.Web.Services
{
    public class BookService : IBookService
    {
        private readonly HttpClient httpClient;

        public BookService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await httpClient.GetJsonAsync<Book[]>("api/books");
        }
    }
}
