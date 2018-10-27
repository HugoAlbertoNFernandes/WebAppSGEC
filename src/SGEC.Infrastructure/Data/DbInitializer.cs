using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EGEC.ApplicationCore.Entity;

namespace SGEC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Inicializer(EcommerceContext context)
        {
            if (context.Users.Any())
            { }
            else
            {
                var perfil = new Perfil[] {
                new Perfil{
                    Nome = "Administrador",
                    Descricao = "Administrador do Sistema"
                }
            };
                context.AddRange(perfil);

                var users = new User[] {
                new User{
                    Nome = "Administrador",
                    Login = "Adminsitrador",
                    Senha = "LojaVirtual123",
                    Perfil = perfil[0]
                }
            };
                context.AddRange(users);
            }
            if (context.Categorias.Any())
            { }
            else
            {
                var categoria = new Categoria[] {
                new Categoria{
                    Nome = "Eletrônicos",
                },
                new Categoria{
                    Nome = "Jogos",
                    SubCategoriaId=1
                },
                new Categoria{
                    Nome = "XBOX",
                    SubCategoriaId=2
                },
                new Categoria{
                    Nome = "Play Station",
                    SubCategoriaId=2
                },
                new Categoria{
                    Nome = "Livros"
                },
                new Categoria{
                    Nome = ".Net Core 2",
                    SubCategoriaId=2
                }
            };
                context.AddRange(categoria);
            }

            context.SaveChanges();
        }
    }
}
