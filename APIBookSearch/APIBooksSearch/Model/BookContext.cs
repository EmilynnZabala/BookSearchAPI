
using Microsoft.EntityFrameworkCore;

namespace APIBooksSearch.Model
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) 
        { 
            Database.EnsureCreated();
        
        }

        public DbSet<Book> Books { get; set; }
        
    }
}
