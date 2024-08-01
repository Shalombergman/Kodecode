using System.ComponentModel.DataAnnotations;

namespace MVCBooksSystem.Models
{
    public class BookSet
    {
        [Key]
        public int SetID { get; set; }
        [Required]
        [StringLength(100)]
        public string SetName { get; set; }

        public List<Book>? Books { get; set; }
    }
}
