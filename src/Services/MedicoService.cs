
using ModeloCeub.Data;
using ModeloCeub.Interfaces.Services;
using ModeloCeub.Models;

namespace ModeloCeub.Services;

public class MedicoService : ServiceBase<Medico>, IMedicoService
{
    private readonly CeubDbContext _context;

    public MedicoService(CeubDbContext context)
    : base(context)
    {
        _context = context;
    }


}