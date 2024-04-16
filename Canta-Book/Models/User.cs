namespace Canta_Book.Models
{
    public class User
    {
        public int UserID { get; set; } //PK
        public string UserName { get; set; }
        public string Mail { get; set; }
        public List<Book>? Historic { get; set; }
    }
}
