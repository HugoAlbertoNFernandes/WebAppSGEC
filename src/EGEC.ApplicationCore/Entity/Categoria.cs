using System;
using System.Collections.Generic;
using System.Text;

namespace EGEC.ApplicationCore.Entity
{
    public class Categoria
    {
        public Categoria()
        {

        }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string UrlString { get; set; }
        public int? SubCategoriaId { get; set; }
        public ICollection<Categoria> SubCategoria { get; set; }
        //public int ProdutoId { get; set; }
        //public Produto Produto { get; set; }
        public ICollection<ProdutoCategoria> ProdutoCategorias { get; set; }
    }
}
