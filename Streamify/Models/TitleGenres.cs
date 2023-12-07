using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("title_genres")]
public class TitleGenres {

    [Key]
    [Column("title_id")]
    public Int TitleId { get; set; }

    [Key]
    [Column("genre_id")]
    public Int GenreId { get; set; }
}