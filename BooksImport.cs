// See https://aka.ms/new-console-template for more information
using Books.Interfaces;
using Books.Models;
using Books.Utils;

internal class BooksImport : IImporter
{
    private readonly IBookRepository _repo;
    private const string _bookSourceUrl = "https://www.w3schools.com/xml/books.xml";

    
    public BooksImport()
    {
      // When doing this for real IBookRespository would be dependancy injected here.
      //_repo = repo;
    }

    public void Import()
    {
        //created a utility class to handle the serialization of the books xml this takes a url and returns the list of books.
        // This kept the implementation simple
        var books = BookUtility.GetBooks(_bookSourceUrl);
        SaveAllToDatabase(books);
    }

    internal void SaveAllToDatabase(List<Book> books)
    {
        _repo.saveAll(books);
    }
}