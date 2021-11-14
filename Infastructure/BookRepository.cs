using Books.Interfaces;
using Books.Models;
using Microsoft.EntityFrameworkCore;

namespace Books.Infastructure
{
    //Normally I would look to split this out into sepearte projects that would then be injected 
    //into this keeping everything seperate and neat by using the Reposority Pattern.
    public class BookRepository : IBookRepository
    {
        private readonly DbContext _context;
        public BookRepository(DbContext dbContext) {
            _context = dbContext;
        }
        public void saveAll(List<Book> books)
        {
            _context.AddRange(books);
        }

        public void save(Book book)
        {
            _context.Add(book);
        }
    }
}