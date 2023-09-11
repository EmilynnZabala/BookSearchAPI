using APIBooksSearch.Model;
using APIBooksSearch.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace APIBooksSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookRepositorio _bookRepositorio;
        public BookController(IBookRepositorio bookRepositorio)
        {
            _bookRepositorio = bookRepositorio;
        }

        [HttpGet]

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookRepositorio.Get();
        }

        [HttpGet("{Id}")]

        public async Task<ActionResult<Book>> GetBooks(int Id)
        {
            return await _bookRepositorio.Get(Id);
        }

        [HttpPost]

        public async Task<ActionResult<Book>> PostBooks([FromBody] Book book)
        {
            var newBook = await _bookRepositorio.create(book);
            return CreatedAtAction(nameof(GetBooks), new { id = newBook.Id }, newBook);

        }

    }
}
