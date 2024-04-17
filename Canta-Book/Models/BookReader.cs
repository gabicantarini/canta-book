using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Canta_Book.Models
{
    public class BookReader
    {
        [Key]
        public int BookReaderID { get; set; } //PK           

        [ForeignKey("Book")]
        public int BookID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public int BookRate { get; set; }        
        public DateTime FinishDate { get; set; }
        public DateTime StartDate { get; set; }
        public string? BookComment { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }

    }
}
