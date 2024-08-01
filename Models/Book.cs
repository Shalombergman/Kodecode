using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCBooksSystem.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(100)]
        public string Author { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Width { get; set; }   
        public int? GenreId { get; set; }
        public int? SetId { get; set; }
        public int? ShelvId { get; set; }
        public Genre? Genre { get; set; }
        public BookSet? BookSet { get; set; }
        public Shelv? Shelv { get; set; }
       
    }

}

