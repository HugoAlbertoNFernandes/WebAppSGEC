using EGEC.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.Data
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) :base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ClienteEndereco> ClienteEnderecos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<ClienteEndereco>().ToTable("ClienteEndereco");
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Perfil>().ToTable("Perfil");
            


            #region Clientes
            modelBuilder.Entity<Cliente>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();
            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Cliente>().Property(e => e.Email)
                .HasColumnType("varchar(250)")
                .IsRequired();
            modelBuilder.Entity<Cliente>().Property(e => e.telefone)
                .HasColumnType("varchar(21)");
            modelBuilder.Entity<Cliente>().Property(e => e.telefone1)
                .HasColumnType("varchar(21)");
            #endregion

            #region ClienteEndereco
            modelBuilder.Entity<ClienteEndereco>().Property(e => e.Logradouro)
                .HasColumnType("varchar(200)");
            modelBuilder.Entity<ClienteEndereco>().Property(e => e.Bairro)
                .HasColumnType("varchar(100)");
            modelBuilder.Entity<ClienteEndereco>().Property(e => e.Cep)
                .HasColumnType("varchar(20)");
            modelBuilder.Entity<ClienteEndereco>().Property(e => e.Referencia)
                .HasColumnType("varchar(400)");
            #endregion

            #region Produto
            modelBuilder.Entity<Produto>().Property(e => e.Nome)
                .HasColumnType("varchar(100)");
            modelBuilder.Entity<Produto>().Property(e => e.DescricaoCurta)
                .HasColumnType("varchar(100)");
            modelBuilder.Entity<Produto>().Property(e => e.DescricaoLoga)
                .HasColumnType("varchar(1000)");
            modelBuilder.Entity<Produto>().Property(e => e.ImgUrl)
                .HasColumnType("varchar(400)");
            modelBuilder.Entity<Produto>().Property(e => e.ImgUrl1)
                .HasColumnType("varchar(400)");
            modelBuilder.Entity<Produto>().Property(e => e.ImgUrl2)
                .HasColumnType("varchar(400)");
            modelBuilder.Entity<Produto>().Property(e => e.ImgUrl3)
                .HasColumnType("varchar(400)");
            modelBuilder.Entity<Produto>().Property(e => e.ImgUrl4)
                .HasColumnType("varchar(400)");
            modelBuilder.Entity<Produto>().Property(e => e.ImgUrl5)
                .HasColumnType("varchar(400)");
            #endregion

            #region Categoria
            modelBuilder.Entity<Categoria>().Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Categoria>().Property(e => e.UrlString)
                .HasColumnType("varchar(400)");
            #endregion

            #region User
            modelBuilder.Entity<User>().Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<User>().Property(e => e.Senha)
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<User>().Property(e => e.Login)
                .HasColumnType("varchar(100)")
                .IsRequired();
            #endregion

            #region Perfil
            modelBuilder.Entity<Perfil>().Property(e => e.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Perfil>().Property(e => e.Descricao)
                .HasColumnType("varchar(300)");
            #endregion
            //base.OnModelCreating(modelBuilder);
        }
    }
}
