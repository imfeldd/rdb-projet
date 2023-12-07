using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("ratings")]
public class Ratings {
    [Key]
    [Column("user_id")]
    public Int UserId { get; set; }

    [Key]
    [Column("title_id")]
    public Int TitleId { get; set; }

    [Column("does_recommend")]
    public Boolean DoesRecommend { get; set; }
}