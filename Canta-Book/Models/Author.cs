namespace Canta_Book.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }

        public Book WriterName { get; set; }
        //public List<Book> ListBooks { get; set; }
    }
}
