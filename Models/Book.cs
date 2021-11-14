using System.Xml.Serialization;
using Books.Models;

namespace Books.Models
{
    [XmlRoot(ElementName = "title")]
    public class Title
    {

        [XmlAttribute(AttributeName = "lang")]
        public string Lang;

        [XmlText]
        public string Text;
    }

    [XmlRoot(ElementName = "book")]
    public class Book
    {
        //I would have perfered to split these out into a specific object for convience later
        [XmlElement(ElementName = "author")]
        public List<string> Authors;

        // [XmlElement(ElementName = "author")]
        // public List<Author> AuthorsList;

        [XmlElement(ElementName = "price")]
        public double Price;

        [XmlAttribute(AttributeName = "category")]
        public string Category;

        [XmlElement(ElementName = "title")]
        public Title Title;

    }

    [XmlRoot(ElementName = "bookstore")]
    public class Bookstore
    {

        [XmlElement(ElementName = "book")]
        public List<Book> Books;
    }
}