namespace ModeloCeub.Models;
public class Usuario : EntityBase
{
    public string Nome { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Telefone { get; set; } = default!;
}