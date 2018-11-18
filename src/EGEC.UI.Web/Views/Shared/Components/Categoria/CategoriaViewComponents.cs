using EGEC.ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EGEC.UI.Web.Views.Shared.Components.Categoria
{
    [ViewComponent(Name = "Categoria")]
    public class CategoriaViewComponents : ViewComponent
    {
        IMenuService db;
        
        public CategoriaViewComponents(IMenuService _categ)
        {
            db = _categ;
        }
        public async Task<IViewComponentResult> InvokeAsync() {
            var vcateg = db.ObterTodos();
            return View("Index",vcateg);
            //return View("Index");
        }
        private Task<IEnumerable<ICategoriaService>> GetItemsAsync()
        {
            var vcateg = db.ObterTodos();
            return vcateg;
        }
    }
}
