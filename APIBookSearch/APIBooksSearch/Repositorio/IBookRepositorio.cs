using APIBooksSearch.Model;

namespace APIBooksSearch.Repositorio
{
    public interface IBookRepositorio
    {
        Task<IEnumerable<Book>> Get();

        Task<Book> Get(int Id);

        Task<Book> create(Book book);   


    }
}
