using EGEC.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.EntityConfig
{
    public class ClienteEnderecoMap : IEntityTypeConfiguration<ClienteEndereco>
    {
        public void Configure(EntityTypeBuilder<ClienteEndereco> builder)
        {
            builder.HasKey(e => e.ClienteEnderecoid);

            builder
                .HasOne(c => c.Cliente)
                .WithMany(c => c.ClienteEndereco)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.Logradouro)
                .HasColumnType("varchar(200)");
            builder.Property(e => e.Bairro)
                .HasColumnType("varchar(100)");
            builder.Property(e => e.Cep)
                .HasColumnType("varchar(20)");
            builder.Property(e => e.Referencia)
                .HasColumnType("varchar(400)");
        }
    }
}
