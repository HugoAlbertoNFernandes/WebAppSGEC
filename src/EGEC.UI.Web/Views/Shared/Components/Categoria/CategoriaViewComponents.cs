using EGEC.ApplicationCore.Interfaces.Repository;
using EGEC.ApplicationCore.Services;
using Microsoft.AspNetCore.Mvc;
using SGEC.Infrastructure.Data;
using SGEC.Infrastructure.Repository;
using System.Threading.Tasks;

namespace EGEC.UI.Web.Views.Shared.Components.Categoria
{
    [ViewComponent(Name = "Categoria")]
    public class CategoriaViewComponents : ViewComponent
    {
        CategoriaService db;
        
        public CategoriaViewComponents(CategoriaService _categ)
        {
            db = _categ;
        }
        public async Task<IViewComponentResult> InvokeAsync() {
            db.ObterTodos();
            


            return View("Index");
        }
    }
}
