using System;
using System.Collections.Generic;
using System.Text;

namespace EGEC.ApplicationCore.Entity
{
    public class Perfil
    {
        public Perfil()
        {

        }
        public int PerfilId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<User> Users { get; set; } // o perfil tem um unico usuário
    }
}
