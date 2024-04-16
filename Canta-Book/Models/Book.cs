using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Canta_Book.Models
{
    public class Book
    {
        //[Key]
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string Description { get; set; }

        [ForeignKey("Author")]
        public int AuthorID { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

        public Author? Author { get; set; }
        //public List<BookReader>? Comment { get; set; }

        //public List<BookReader>? BookRate { get; set; }
    }
}
