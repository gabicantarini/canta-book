namespace Canta_Book.Models
{
    public class BookReader
    {
        public int BookReaderID { get; set; } //PK           
        
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int UserID { get; set; }
        //public User User { get; set; }
        public int BookRate { get; set; }        
        public DateTime FinishDate { get; set; }
        public DateTime StartDate { get; set; }
        public string? BookComment { get; set; }
        public List<Book> BookTitle { get; set; } 
        public List<User> UserName { get; set; } 

    }
}
