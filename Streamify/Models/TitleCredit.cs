using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;

public enum RoleType
{
  actor,
  director
}

[Table("title_credits")]
public class TitleCredit {

    [Key]
    [Column("person_id")]
    public Person Person { get; set; }

    [Column("title_id")]
    public Title Title { get; set; }

    [Column("character_name")]
    public string CharacterName { get; set; }

    [Column("role")]
    public RoleType Role { get; set; }
}