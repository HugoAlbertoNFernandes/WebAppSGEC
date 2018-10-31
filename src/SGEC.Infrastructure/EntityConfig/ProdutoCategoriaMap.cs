using EGEC.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.EntityConfig
{
    public class ProdutoCategoriaMap : IEntityTypeConfiguration<ProdutoCategoria>
    {
        public void Configure(EntityTypeBuilder<ProdutoCategoria> builder)
        {
            builder.HasKey(pc => pc.id);

            builder
                .HasOne(c => c.Categorias)
                .WithMany(c => c.ProdutoCategorias)
                .HasForeignKey(c => c.CategoriaId);

            builder
                .HasOne(c => c.Produtos)
                .WithMany(c => c.ProdutoCategoria)
                .HasForeignKey(c => c.ProdutoId);
        }
    }
}
