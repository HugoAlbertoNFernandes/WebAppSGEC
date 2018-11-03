using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Repository;
using SGEC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.Repository
{
    public class CategoriaRepository : EFRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(EcommerceContext dbContext) : base(dbContext)
        {

        }
    }
}
