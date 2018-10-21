using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EGEC.ApplicationCore.Entity;

namespace SGEC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Inicializer(EcommerceContext context) {
            if (context.Users.Any()) {
                return;
            }

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

            context.SaveChanges();
        }
    }
}
