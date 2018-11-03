using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Repository;
using EGEC.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace EGEC.ApplicationCore.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;
        public UserService(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public User Adicionar(User entity)
        {
            // Aqui coloca todas as verificações das regras de negocios e não no controller
            // Verificar os dados por exemplo.
            // se não comportar retornar null
            if (true)
                return _UserRepository.Adicionar(entity);
            //else
            //    return null;
        }

        public void Atualizar(User entity)
        {
            _UserRepository.Atualizar(entity);
        }

        public IEnumerable<User> Buscar(Expression<Func<User, bool>> predicado)
        {
            return _UserRepository.Buscar(predicado);
        }

        public User ObterPorId(int id)
        {
            return _UserRepository.ObterPorId(id);
        }

        public IEnumerable<User> ObterTodos()
        {
            return _UserRepository.ObterTodos();
        }

        public void Remover(User entity)
        {
            _UserRepository.Remover(entity);
        }
    }
}
