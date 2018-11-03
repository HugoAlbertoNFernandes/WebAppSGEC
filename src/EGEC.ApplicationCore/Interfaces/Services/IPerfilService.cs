using EGEC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EGEC.ApplicationCore.Interfaces.Services
{
    public interface IPerfilService
    {
        Perfil Adicionar(Perfil entity);
        void Atualizar(Perfil entity);
        IEnumerable<Perfil> ObterTodos();
        Perfil ObterPorId(int id);
        IEnumerable<Perfil> Buscar(Expression<Func<Perfil, bool>> predicado);
        void Remover(Perfil entity);
    }
}
