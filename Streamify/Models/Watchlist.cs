using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("watchlists")]
public class Watchlist {

    [Key]
    [Column("watch_id")]
    public int WatchId { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("title_id")]
    public int TitleId { get; set; }

    [Column("viewed_at")]
    public string ViewedAt { get; set; }
}