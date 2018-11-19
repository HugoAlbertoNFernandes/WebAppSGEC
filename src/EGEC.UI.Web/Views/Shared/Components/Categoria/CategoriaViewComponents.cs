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
            var vcateg1 = db.CriarMenu();
            return View(vcateg1);
            //return View("Index");
        }
        //private Task<IEnumerable<IMenuService>> GetItemsAsync()
        //{
        //    var vcateg = db.ObterTodos();
        //    return vcateg;
        //}
    }
}
