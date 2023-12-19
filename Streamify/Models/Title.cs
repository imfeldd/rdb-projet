using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;

public enum ContentTypes
{
  show,
  movie
}


[Table("titles")]
public class Title {

    [Key]
    [Column("title_id")]
    public int TitleId { get; set; }

    [Column("title")]
    public string? TitleName { get; set; }

    public List<Genre> Genres { get; set; } = new();

    public List<TitleGenre> TitleGenres { get; } = new();

    public virtual List<TitleCredit> Credits { get; set; } = new();

    public List<Rating> Ratings { get; set;} = new();

    [Column("description")]
    public string? Description { get; set; }

    [Column("release_year")]
    public int ReleaseYear { get; set; }

    [Column("age_certification")]
    public string? AgeCertification { get; set; }

    [Column("runtime")]
    public int Runtime { get; set; }

    [Column("seasons")]
    public int? Seasons { get; set; }
}