using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("users")]
public class User {
    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("name")]
    public string Name { get; set; }
}