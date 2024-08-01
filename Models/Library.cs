using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCBooksSystem.Models
{
    public class Library
    {
        [Key]
        public int LibraryID { get; set; }
        public int? GenreId { get; set; }
        public Genre? Genre { get; set; }
        public List<Shelv>? Shelves { get; set; }
    }
}
