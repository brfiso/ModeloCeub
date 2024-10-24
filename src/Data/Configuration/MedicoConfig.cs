
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModeloCeub.Models;

namespace ModeloCeub.Data.Configuration;

public class MedicoConfig : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.Property(x => x.Crm)
        .IsRequired()
        .HasColumnType("varchar(20)");

        builder.HasOne(x => x.Usuario);

    }
}