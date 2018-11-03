using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Repository;
using EGEC.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EGEC.ApplicationCore.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _ProdutoRepository;
        public ProdutoService(IProdutoRepository ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
        }

        public Produto Adicionar(Produto entity)
        {
            // Aqui coloca todas as verificações das regras de negocios e não no controller
            // Verificar os dados por exemplo.
            // se não comportar retornar null
            if (true)
                return _ProdutoRepository.Adicionar(entity);
            //else
            //    return null;
        }

        public void Atualizar(Produto entity)
        {
            _ProdutoRepository.Atualizar(entity);
        }

        public IEnumerable<Produto> Buscar(Expression<Func<Produto, bool>> predicado)
        {
            return _ProdutoRepository.Buscar(predicado);
        }

        public Produto ObterPorId(int id)
        {
            return _ProdutoRepository.ObterPorId(id);
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _ProdutoRepository.ObterTodos();
        }

        public void Remover(Produto entity)
        {
            _ProdutoRepository.Remover(entity);
        }
    }
}
