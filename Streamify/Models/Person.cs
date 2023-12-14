using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("person")]
public class Person {

    [Key]
    [Column("person_id")]
    public int PersonId { get; set; }

    [Column("name")]
    public String Name { get; set; }

    public virtual List<TitleCredit> Credits { get; set; } = new();
}