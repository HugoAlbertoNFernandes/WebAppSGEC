using System;
using System.Collections.Generic;
using System.Text;

namespace EGEC.ApplicationCore.Entity
{
    public class ProdutoCategoria
    {
        public ProdutoCategoria()
        {

        }
        public int id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produtos { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categorias { get; set; }
    }
}
