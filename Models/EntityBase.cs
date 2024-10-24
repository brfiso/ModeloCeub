
using System.ComponentModel.DataAnnotations;

namespace ModeloCeub.Models;

public class EntityBase
{
    [Key]
    public int Id { get; set; }
}
