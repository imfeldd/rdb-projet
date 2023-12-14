using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("title_genres")]
public class TitleGenre {
    [Column("title_id")]
    public int TitleId { get; set; }

    [Column("genre_id")]
    public int GenreId { get; set; }
}