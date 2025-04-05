using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BooksApi;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            var books = new List<Book> {
                new Book {
                    Id = 1,
                    BookName = "Alexander Rangelov",
                    BookAuthor = "Alexandar Rangelov",
                    ISBN = "da12d44k"
                }
            };
            return Ok(books);
        }
    }
}
