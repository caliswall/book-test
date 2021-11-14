using System.Xml.Serialization;

namespace Books.Models
{
    [XmlRoot(ElementName = "author")]
    public class Author
    {
        [XmlText]
        string author {get; set;}
    }
}