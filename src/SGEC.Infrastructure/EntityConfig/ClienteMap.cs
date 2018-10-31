using EGEC.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.ClienteId);

            builder
                .HasMany(e => e.ClienteEndereco)
                .WithOne(e => e.Cliente)
                .HasForeignKey(e => e.ClienteId)
                .HasPrincipalKey(e => e.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();
            builder.Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder.Property(e => e.Email)
                .HasColumnType("varchar(250)")
                .IsRequired();
            builder.Property(e => e.telefone)
                .HasColumnType("varchar(21)");
            builder.Property(e => e.telefone1)
                .HasColumnType("varchar(21)");
        }
    }
}
