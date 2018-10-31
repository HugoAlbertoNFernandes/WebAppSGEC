using EGEC.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.EntityConfig
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.CategoriaId);

            builder
                .HasMany(s => s.SubCategoria)
                .WithOne()
                .HasForeignKey(s => s.SubCategoriaId)
                .HasPrincipalKey(c => c.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(e => e.UrlString)
                .HasColumnType("varchar(400)");
        }
    }
}
