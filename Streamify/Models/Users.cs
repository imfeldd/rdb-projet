using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("users")]
public class Users {
    [Key]
    [Column("user_id")]
    public Int UserId { get; set; }

    [Column("email")]
    public String Email { get; set; }

    [Column("name")]
    public String Name { get; set; }
}