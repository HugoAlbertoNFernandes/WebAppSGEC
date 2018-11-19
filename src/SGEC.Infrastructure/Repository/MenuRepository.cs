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

        public IList<Menu> CriarMenu()
        {
            var _menu = new List<Menu>(Buscar(x => x.MenuId == null));
            for (int i = 0; i < _menu.Count; i++)
            {
                var _Submenu = new List<Menu>(Buscar(x => x.MenuId == _menu[i].id));
                for (int j = 0; j < _Submenu.Count; j++)
                {
                    _menu[i].SubMenu.Add(_Submenu[j]);
                }                
            }
            return _menu;
        }
    }
}
