using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Repository;
using EGEC.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EGEC.ApplicationCore.Services
{
    public class PerfilService : IPerfilService
    {
        private readonly IPerfilRepository _PerfilRepository;
        public PerfilService(IPerfilRepository PerfilRepository)
        {
            _PerfilRepository = PerfilRepository;
        }

        public Perfil Adicionar(Perfil entity)
        {
            // Aqui coloca todas as verificações das regras de negocios e não no controller
            // Verificar os dados por exemplo.
            // se não comportar retornar null
            if (true)
                return _PerfilRepository.Adicionar(entity);
            //else
            //    return null;
        }

        public void Atualizar(Perfil entity)
        {
            _PerfilRepository.Atualizar(entity);
        }

        public IEnumerable<Perfil> Buscar(Expression<Func<Perfil, bool>> predicado)
        {
            return _PerfilRepository.Buscar(predicado);
        }

        public Perfil ObterPorId(int id)
        {
            return _PerfilRepository.ObterPorId(id);
        }

        public IEnumerable<Perfil> ObterTodos()
        {
            return _PerfilRepository.ObterTodos();
        }

        public void Remover(Perfil entity)
        {
            _PerfilRepository.Remover(entity);
        }
    }
}
