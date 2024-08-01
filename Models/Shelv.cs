using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCBooksSystem.Models
{
    public class Shelv
    {
        [Key]
        public int ShelvId { get; set; }
              
        [Required]
        public int Height { get; set; }
        [Required]
        public int Width { get; set; }    
        public int? LibraryId { get; set; }
        public Library? Library { get; set; }
        public List<Book>? Books { get; set; }
    }
}
