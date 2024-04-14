namespace Canta_Book.Models
{
    public class BookReader
    {
        public int bookReaderID { get; set; } //PK           
        
        public int bookID { get; set; }        
        public int userID { get; set; }
        public int bookRate { get; set; }        
        public DateTime finishDate { get; set; }
        public DateTime startDate { get; set; }
        public string? bookComment { get; set; }
        public List<Book>? bookTitle { get; set; } 
        public List<User>? userName { get; set; } 

    }
}
