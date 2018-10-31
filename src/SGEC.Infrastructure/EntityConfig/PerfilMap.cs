using EGEC.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.EntityConfig
{
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.HasKey(p => p.PerfilId);

            builder
                .HasMany(u => u.Users)
                .WithOne(p => p.Perfil)
                .HasForeignKey(u => u.PerfilId)
                .HasPrincipalKey(u => u.PerfilId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder.Property(e => e.Descricao)
                .HasColumnType("varchar(300)");
        }
    }
}
