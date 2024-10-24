using System.ComponentModel.DataAnnotations.Schema;

namespace ModeloCeub.Models;

public class Medico : EntityBase
{
    public string Crm { get; set; } = default!;
    public int UsuarioId { get; set; }
    
    [ForeignKey("UsuarioId")]
    public virtual Usuario Usuario { get; set; } = default!;
}