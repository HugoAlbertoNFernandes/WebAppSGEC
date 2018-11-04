using EGEC.ApplicationCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace EGEC.UI.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private UserService user;
        public HomeController()
        {
            UserService _user = null;
            this.user = _user;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(EGEC.ApplicationCore.Entity.User users)
        {
            user.Buscar(x => x.Nome.Contains(users.Nome) && 
            x.Senha.Contains(users.Senha));
            return View();
        }


        public IActionResult About()
        {
            return View();
        }
        public IActionResult First()
        {
            return View();
        }
    }
}