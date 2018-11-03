using EGEC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EGEC.ApplicationCore.Interfaces.Services
{
    public interface IMenuService
    {
        Menu Adicionar(Menu entity);
        void Atualizar(Menu entity);
        IEnumerable<Menu> ObterTodos();
        Menu ObterPorId(int id);
        IEnumerable<Menu> Buscar(Expression<Func<Menu, bool>> predicado);
        void Remover(Menu entity);
    }
}
