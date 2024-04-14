namespace Canta_Book.Models
{
    public class User
    {
        public int userID { get; set; } //PK
        public string userName { get; set; }
        public string mail { get; set; }
        public List<Book> historic { get; set; }
    }
}
