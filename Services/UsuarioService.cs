
using ModeloCeub.Data;
using ModeloCeub.Interfaces.Services;
using ModeloCeub.Models;

namespace ModeloCeub.Services;

public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
{
    private readonly CeubDbContext _context;

    public UsuarioService(CeubDbContext context)
    : base(context)
    {
        _context = context;
    }

}