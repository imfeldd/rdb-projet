using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;

enum ContentTypes 
{
  show,
  movie
}


[Table("titles")]
public class Titles {

    [Key]
    [Column("title_id")]
    public Int TitleId { get; set; }

    [Column("title")]
    public String Title { get; set; }

    [Column("type")]
    public ContentTypes Type { get; set; }

    [Column("description")]
    public String Description { get; set; }

    [Column("release_year")]
    public Int ReleaseYear { get; set; }

    [Column("age_certification")]
    public String AgeCertification { get; set; }

    [Column("runtime")]
    public Integer Runtime { get; set; }

    [Column("seasons")]
    public Integer Seasons { get; set; }
}