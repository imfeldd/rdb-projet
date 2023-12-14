using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("genres")]
public class Genre {
    [Key]
    [Column("genre_id")]
    public int GenreId { get; set; }

    [Column("name")]
    public string Name { get; set; }

    public List<Title> Titles { get; set; } = new();
    public List<TitleGenre> TitleGenres { get; } = new();
}