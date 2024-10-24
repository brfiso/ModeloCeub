using System.ComponentModel.DataAnnotations.Schema;

namespace ModeloCeub.Models;

public class Enfermeiro : EntityBase
{
    public string Cre { get; set; } = default!;

    public int UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public virtual Usuario Usuario { get; set; } = default!;
}
