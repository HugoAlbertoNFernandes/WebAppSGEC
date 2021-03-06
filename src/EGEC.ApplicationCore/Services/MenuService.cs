﻿using EGEC.ApplicationCore.Entity;
using EGEC.ApplicationCore.Interfaces.Repository;
using EGEC.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EGEC.ApplicationCore.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _MenuRepository;
        public MenuService(IMenuRepository MenuRepository)
        {
            _MenuRepository = MenuRepository;
        }

        public Menu Adicionar(Menu entity)
        {
            // Aqui coloca todas as verificações das regras de negocios e não no controller
            // Verificar os dados por exemplo.
            // se não comportar retornar null
            if (true)
                return _MenuRepository.Adicionar(entity);
            //else
            //    return null;
        }

        public void Atualizar(Menu entity)
        {
            _MenuRepository.Atualizar(entity);
        }

        public IEnumerable<Menu> Buscar(Expression<Func<Menu, bool>> predicado)
        {
            return _MenuRepository.Buscar(predicado);
        }

        public Menu ObterPorId(int id)
        {
            return _MenuRepository.ObterPorId(id);
        }

        public IEnumerable<Menu> ObterTodos()
        {
            return _MenuRepository.ObterTodos();
        }

        public void Remover(Menu entity)
        {
            _MenuRepository.Remover(entity);
        }

        public IList<Menu> CriarMenu()
        {
            var _menu = new List<Menu>(Buscar(x => x.MenuId == null));
            for (int i = 0; i < _menu.Count; i++)
            {
                var _Submenu = new List<Menu>(Buscar(x => x.MenuId == _menu[i].id));
                for (int j = 0; j < _Submenu.Count; j++)
                {
                    _menu[i].SubMenu.Add(_Submenu[j]);
                }
            }
            return _menu;
        }
    }
}
