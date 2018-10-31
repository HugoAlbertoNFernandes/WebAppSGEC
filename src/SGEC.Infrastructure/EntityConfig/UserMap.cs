using EGEC.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.EntityConfig
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder
                .HasOne(p => p.Perfil)
                .WithMany(c => c.Users)
                .HasForeignKey(u => u.PerfilId)
                .HasPrincipalKey(u => u.PerfilId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder.Property(e => e.Senha)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder.Property(e => e.Login)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
