
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModeloCeub.Models;

namespace ModeloCeub.Data.Configuration;

public class EnfermeiroConfig : IEntityTypeConfiguration<Enfermeiro>
{
    public void Configure(EntityTypeBuilder<Enfermeiro> builder)
    {
        builder.Property(x => x.Cre)
        .IsRequired()
        .HasColumnType("varchar(20)");

        builder.HasOne(x => x.Usuario);

    }
}