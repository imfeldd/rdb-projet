using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("watchlists")]
public class Watchlists {

    [Key]
    [Column("watch_id")]
    public Int WatchId { get; set; }

    [Column("user_id")]
    public Int UserId { get; set; }

    [Column("title_id")]
    public Int TitleId { get; set; }

    [Column("viewed_at")]
    public String ViewedAt { get; set; }
}