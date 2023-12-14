using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("ratings")]
public class Rating {
    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [Key]
    [Column("title_id")]
    public int TitleId { get; set; }

    [Column("does_recommend")]
    public bool DoesRecommend { get; set; }
}