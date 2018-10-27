using System;
using System.Collections.Generic;
using System.Text;

namespace EGEC.ApplicationCore.Entity
{
    public class Menu
    {
        public Menu()
        {

        }
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Link { get; set; }
        public int? MenuId { get; set; }
        public ICollection<Menu> SubMenu { get; set; }
    }
}
