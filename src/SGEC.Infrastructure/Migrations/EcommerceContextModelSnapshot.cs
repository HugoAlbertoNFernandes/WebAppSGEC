﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SGEC.Infrastructure.Data;

namespace SGEC.Infrastructure.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    partial class EcommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EGEC.ApplicationCore.Entity.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("ProdutoId");

                    b.Property<string>("UrlString")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.HasKey("CategoriaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("EGEC.ApplicationCore.Entity.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("telefone")
                        .HasColumnType("varchar(21)");

                    b.Property<string>("telefone1")
                        .HasColumnType("varchar(21)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("EGEC.ApplicationCore.Entity.Perfil", b =>
                {
                    b.Property<int>("PerfilId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("PerfilId");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("EGEC.ApplicationCore.Entity.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoCurta")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DescricaoLoga")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<string>("ImgUrl1")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<string>("ImgUrl2")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<string>("ImgUrl3")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<string>("ImgUrl4")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<string>("ImgUrl5")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("EGEC.ApplicationCore.Entity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("PerfilId");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("UserId");

                    b.HasIndex("PerfilId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("EGEC.ApplicationCore.Entity.Categoria", b =>
                {
                    b.HasOne("EGEC.ApplicationCore.Entity.Produto", "Produto")
                        .WithMany("Categoria")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EGEC.ApplicationCore.Entity.User", b =>
                {
                    b.HasOne("EGEC.ApplicationCore.Entity.Perfil", "Perfil")
                        .WithMany("Users")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
