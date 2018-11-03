using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Repository;
using SGEC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SGEC.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(EcommerceContext dbContext):base(dbContext)
        {

        }

        public IEnumerable<Cliente> ObterPorNome(string Nome)
        {
            return Buscar(c=> c.Nome.Contains(Nome));
        }
    }
}
