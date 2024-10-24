
using ModeloCeub.Data;
using ModeloCeub.Interfaces.Services;
using ModeloCeub.Models;

namespace ModeloCeub.Services;

public class EnfermeiroService : ServiceBase<Enfermeiro>, IEnfermeiroService
{
    private readonly CeubDbContext _context;

    public EnfermeiroService(CeubDbContext context)
    : base(context)
    {
        _context = context;
    }
    
}