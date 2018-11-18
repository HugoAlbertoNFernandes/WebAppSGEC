using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Services;
using EGEC.UI.Web.Data;

namespace EGEC.UI.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IUserService _user;

        public HomeController(IUserService user)
        {
            this._user = user;
        }
        public IActionResult Index()
        {
            //var v = a.ObterTodos();
            return View();
        }
        [HttpPost]
        public IActionResult Index(EGEC.ApplicationCore.Entity.User users)
        {
            var vuser= _user.Logar(users.Login, users.Senha).FirstOrDefault();
            if (vuser != null)
            {
                return View("First");
            }
            else { return View(); }
            
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