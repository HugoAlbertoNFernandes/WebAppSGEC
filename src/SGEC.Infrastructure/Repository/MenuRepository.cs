using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Repository;
using SGEC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEC.Infrastructure.Repository
{
    public class MenuRepository : EFRepository<Menu>, IMenuRepository
    {
        public MenuRepository(EcommerceContext dbContext) : base(dbContext)
        {

        }
    }
}
