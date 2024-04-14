namespace Canta_Book.Models
{
    public class Book
    {
        public int bookID { get; set; }
        public string bookTitle { get; set; }
        public string description { get; set; }
        public int authorID { get; set; }
        public decimal price { get; set; }
        public string genre { get; set; }

        public List<BookReader>? comment { get; set; }

        public List<BookReader>? bookRate { get; set; }
    }
}
