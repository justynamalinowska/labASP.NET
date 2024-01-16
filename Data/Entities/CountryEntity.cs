using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;
[Table("Countries")]
public class CountryEntity
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<ProducentEntity> Producents { get; set; }
}