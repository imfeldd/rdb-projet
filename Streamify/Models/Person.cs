using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streamify;


[Table("person")]
public class Person {

    [Key]
    [Column("person_id")]
    public Int PersonId { get; set; }

    [Column("name")]
    public String Name { get; set; }
}