using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;

enum RoleTypes 
{
  actor,
  director
}

[Table("title_credits")]
public class TitleCredits {

    [Key]
    [Column("person_id")]
    public Int PersonId { get; set; }

    [Column("title_id")]
    public Int TitleId { get; set; }

    [Column("character_name")]
    public String CharacterName { get; set; }

    [Column("role")]
    public RoleTypes Role { get; set; }
}