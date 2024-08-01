using System.ComponentModel.DataAnnotations;

namespace MVCBooksSystem.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        [Required]
        [StringLength(50)]
        public string GenreName { get; set; }

        public List<Library>? Libraries { get; set; }
        public List<Book>? Books { get; set; }
    }
}
