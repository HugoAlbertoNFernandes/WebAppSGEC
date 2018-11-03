using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Repository;
using EGEC.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EGEC.ApplicationCore.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _CategoriaRepository;
        public CategoriaService(ICategoriaRepository CategoriaRepository)
        {
            _CategoriaRepository = CategoriaRepository;
        }

        public Categoria Adicionar(Categoria entity)
        {
            // Aqui coloca todas as verificações das regras de negocios e não no controller
            // Verificar os dados por exemplo.
            // se não comportar retornar null
            if (true)
                return _CategoriaRepository.Adicionar(entity);
            //else
            //    return null;
        }

        public void Atualizar(Categoria entity)
        {
            _CategoriaRepository.Atualizar(entity);
        }

        public IEnumerable<Categoria> Buscar(Expression<Func<Categoria, bool>> predicado)
        {
            return _CategoriaRepository.Buscar(predicado);
        }

        public Categoria ObterPorId(int id)
        {
            return _CategoriaRepository.ObterPorId(id);
        }

        public IEnumerable<Categoria> ObterTodos()
        {
            return _CategoriaRepository.ObterTodos();
        }

        public void Remover(Categoria entity)
        {
            _CategoriaRepository.Remover(entity);
        }
    }
}
