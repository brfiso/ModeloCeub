using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ModeloCeub.Models;

namespace ModeloCeub.Data;

public class CeubDbContext : DbContext
{
    public CeubDbContext(DbContextOptions options)
    : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var property in modelBuilder.Model.GetEntityTypes()
                                         .SelectMany(t => t.GetProperties())
                                         .Where(p => p.ClrType == typeof(string)))
        {
            property.SetColumnType("varchar(100)");
        }

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Medico> Medico { get; set; }
    public DbSet<Enfermeiro> Enfermeiro { get; set; }
}