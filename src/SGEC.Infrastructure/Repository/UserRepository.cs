using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Repository;
using SGEC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.Repository
{
    public class UserRepository : EFRepository<User>, IUserRepository
    {
        public UserRepository(EcommerceContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<User> Logar(string vuser, string vsenha)
        {
            return Buscar(x => x.Nome.Contains(vuser) &&
             x.Senha.Contains(vuser));
        }
    }
}
