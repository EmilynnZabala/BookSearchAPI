using APIBooksSearch.Model;
using System.Data.Entity;

namespace APIBooksSearch.Repositorio
{
    public class BookRepositorio : IBookRepositorio
    {
        public readonly BookContext _context;
        public BookRepositorio(BookContext context)  
        {
            _context = context;
        }

        public async Task<Book> create(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;

        }

        public async Task<Book> Get(int Id)
        {
            return await _context.Books.FindAsync(Id);
        }

        public async Task<IEnumerable<Book>> Get()
        {
          return await _context.Books.ToListAsync();
        }
    }
}
