namespace Canta_Book.Models
{
    public class Book
    {
        public int BookID { get; set; }

        public Author Author { get; set; }
        public string BookTitle { get; set; }
        public string Description { get; set; }
        public int AuthorID { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

        public List<BookReader>? Comment { get; set; }

        public List<BookReader>? BookRate { get; set; }
    }
}
