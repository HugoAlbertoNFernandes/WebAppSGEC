using EGEC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EGEC.ApplicationCore.Interfaces.Services
{
    public interface IProdutoService
    {
        Produto Adicionar(Produto entity);
        void Atualizar(Produto entity);
        IEnumerable<Produto> ObterTodos();
        Produto ObterPorId(int id);
        IEnumerable<Produto> Buscar(Expression<Func<Produto, bool>> predicado);
        void Remover(Produto entity);
    }
}
