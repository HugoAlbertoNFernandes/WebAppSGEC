using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Repository;
using EGEC.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EGEC.ApplicationCore.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Adicionar(Cliente entity)
        {
            // Aqui coloca todas as verificações das regras de negocios e não no controller
            // Verificar os dados por exemplo.
            // se não comportar retornar null
            if (true)
                return _clienteRepository.Adicionar(entity);
            //else
            //    return null;
        }

        public void Atualizar(Cliente entity)
        {
            _clienteRepository.Atualizar(entity);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return _clienteRepository.Buscar(predicado);
        }

        public Cliente ObterPorId(int id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(Cliente entity)
        {
            _clienteRepository.Remover(entity);
        }
    }
}
