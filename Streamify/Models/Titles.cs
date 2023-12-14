using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;

public enum ContentTypes {show, movie}


[Table("titles")]
public class Titles {
    

    [Key]
    [Column("title_id")]
    public int TitleId { get; set; }

    [Column("title")]
    public String Title { get; set; }

    [Column("type")]
    public ContentTypes Type { get; set; }

    [Column("description")]
    public String Description { get; set; }

    [Column("release_year")]
    public int ReleaseYear { get; set; }

    [Column("age_certification")]
    public String AgeCertification { get; set; }

    [Column("runtime")]
    public int Runtime { get; set; }

    [Column("seasons")]
    public int Seasons { get; set; }
}