using EGEC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EGEC.ApplicationCore.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        IEnumerable<Cliente> ObterPorNome(String Nome);
    }
}
