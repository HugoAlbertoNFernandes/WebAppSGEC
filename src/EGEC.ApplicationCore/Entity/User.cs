using System;
using System.Collections.Generic;
using System.Text;

namespace EGEC.ApplicationCore.Entity
{
    public class User
    {
        public User()
        {

        }
        public int UserId { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; } //o usuário tem um unico perfil
    }
}
