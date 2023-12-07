using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;

[Table("titles")]
public class Title {

    [Key]
    [Column("title_id")]
    public String Id { get; set; }

    [Column("title_name")]
    public string Name { get; set; }

    [Column("pub_id")]
    public string PublisherId { get; set; }

    [Column("contract")]
    public int Contract { get; set; }
}