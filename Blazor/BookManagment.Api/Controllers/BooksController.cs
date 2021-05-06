using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookManagment.Api.Models;
using Microsoft.AspNetCore.Http;
using BookManagment.Models;

namespace BookManagment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BooksController : ControllerBase
    {
        private readonly IBookRepository bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetBooks()
        {
            try
            {
                return Ok(await bookRepository.GetBooks());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data");
            }
        }

        [HttpGet("{authorId:int}")]
        public async Task<ActionResult<Book>> GetBook(int authorId)
        {
            try
            {
                var result = await bookRepository.GetBook(authorId);

                    if(result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Book>> RateBook(int id, Book book)
        {
            try
            {
                if(id != book.Id)
                {
                    return BadRequest("Book ID mismatch");
                }

                var bookToUpdate = bookRepository.GetBook(id);

                if(bookToUpdate == null)
                {
                    return NotFound($"Book with Id = {id} not found.");
                }

                return await bookRepository.RateBook(book);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
            }
        }
    }
}
