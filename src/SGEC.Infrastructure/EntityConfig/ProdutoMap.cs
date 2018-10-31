using EGEC.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.EntityConfig
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(e => e.ProdutoId);

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(100)");
            builder.Property(e => e.DescricaoCurta)
                .HasColumnType("varchar(100)");
            builder.Property(e => e.DescricaoLoga)
                .HasColumnType("varchar(1000)");
            builder.Property(e => e.ImgUrl)
                .HasColumnType("varchar(400)");
            builder.Property(e => e.ImgUrl1)
                .HasColumnType("varchar(400)");
            builder.Property(e => e.ImgUrl2)
                .HasColumnType("varchar(400)");
            builder.Property(e => e.ImgUrl3)
                .HasColumnType("varchar(400)");
            builder.Property(e => e.ImgUrl4)
                .HasColumnType("varchar(400)");
            builder.Property(e => e.ImgUrl5)
                .HasColumnType("varchar(400)");
        }
    }
}
