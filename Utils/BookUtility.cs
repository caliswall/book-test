using System.Xml;
using System.Xml.Serialization;
using Books.Models;

namespace Books.Utils
{

    internal static class BookUtility
    {
        private static Bookstore _bookstore;

        ///<Summary>
        ///  Returns a deserialized list of books from a xml url.
        ///</Summary>
        internal static List<Book> GetBooks(string url)
        {
            XmlReader xReader = XmlReader.Create(url);
            XmlSerializer serializer = new XmlSerializer(typeof(Bookstore));
            _bookstore = (Bookstore)serializer.Deserialize(xReader);

            return _bookstore.Books;
        }
    }
}
