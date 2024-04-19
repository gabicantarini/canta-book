using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Canta_Book.Models
{
    public class User
    {
        [Key]
        //[Column("userID")]
        public int UserID { get; set; } //PK
        public string UserName { get; set; }
        public string Mail { get; set; }
        //public List<Book>? Historic { get; set; }
        //public List<BookReader> Historic { get; set; }
    }
}
