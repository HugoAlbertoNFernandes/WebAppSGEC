using EGEC.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.EntityConfig
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(m => m.id);

            builder
                .HasMany(m => m.SubMenu)
                .WithOne()
                .HasForeignKey(m => m.MenuId)
                .HasPrincipalKey(m => m.id);

            builder.Property(m => m.Titulo)
                .HasColumnType("varchar(100)");
            builder.Property(m => m.Link)
                .HasColumnType("varchar(400)");
        }
    }
}
