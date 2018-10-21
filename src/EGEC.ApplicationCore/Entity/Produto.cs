using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EGEC.ApplicationCore.Entity
{
    public class Produto
    {
        public Produto()
        {

        }

        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string DescricaoLoga { get; set; }
        public string DescricaoCurta { get; set; }
        public string ImgUrl { get; set; }
        public string ImgUrl1 { get; set; }
        public string ImgUrl2 { get; set; }
        public string ImgUrl3 { get; set; }
        public string ImgUrl4 { get; set; }
        public string ImgUrl5 { get; set; }
        public ICollection<Categoria> Categoria { get; set; }
    }
}
