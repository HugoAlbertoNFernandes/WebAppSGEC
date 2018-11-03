using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Repository;
using SGEC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.Repository
{
    public class ProdutoRepository : EFRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(EcommerceContext dbContext) : base(dbContext)
        {

        }
    }
}
