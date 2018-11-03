﻿using EGEC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EGEC.ApplicationCore.Interfaces.Services
{
    public interface ICategoriaService
    {
        Categoria Adicionar(Categoria entity);
        void Atualizar(Categoria entity);
        IEnumerable<Categoria> ObterTodos();
        Categoria ObterPorId(int id);
        IEnumerable<Categoria> Buscar(Expression<Func<Categoria, bool>> predicado);
        void Remover(Categoria entity);
    }
}
