using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Models;

namespace Books.Interfaces
{
    public interface IBookRepository
    {
        ///<Summary>
        ///Saves a book to the database
        ///</Summary>
        void save(Book book);
        ///<Summary>
        ///Saves a list of books to the database
        ///</Summary>
        void saveAll(List<Book>books);
    }
}