using EGEC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EGEC.ApplicationCore.Interfaces.Services
{
    public interface IUserService
    {
        IEnumerable<User> Logar(string vuser, string vsenha);
        User Adicionar(User entity);
        void Atualizar(User entity);
        IEnumerable<User> ObterTodos();
        User ObterPorId(int id);
        IEnumerable<User> Buscar(Expression<Func<User, bool>> predicado);
        void Remover(User entity);
    }
}
