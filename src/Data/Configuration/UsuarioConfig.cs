
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModeloCeub.Models;

namespace ModeloCeub.Data.Configuration;

public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.Property(x => x.Nome)
        .IsRequired()
        .HasColumnType("varchar(80)");

        builder.Property(x => x.Email)
        .IsRequired()
        .HasColumnType("varchar(80)");

        builder.Property(x => x.Telefone)
        .IsRequired()
        .HasColumnType("varchar(20)");
    }
}