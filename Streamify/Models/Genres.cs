using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("genres")]
public class Genres {

    [Key]
    [Column("genre_id")]
    public int GenreId { get; set; }

    [Column("name")]
    public String Name { get; set; }
}