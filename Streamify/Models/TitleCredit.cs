using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Streamify;

public enum RoleType
{
  actor,
  director
}

[Table("title_credits")]
[PrimaryKey(nameof(PersonId), nameof(TitleId))]
public class TitleCredit {

    [Column("person_id")]
    public int PersonId { get; }

    [Column("title_id")]
    public int TitleId { get; }

    [Column("person_id")]
    public Person Person { get; set; }

    [Column("title_id")]
    public Title Title { get; set; }

    [Column("character_name")]
    public string CharacterName { get; set; }
}