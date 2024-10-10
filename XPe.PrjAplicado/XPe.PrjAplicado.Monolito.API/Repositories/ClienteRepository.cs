﻿using System;
using System.Collections.Generic;
using System.Linq;
using XPe.PrjAplicado.Interop.Repositories;
using XPe.PrjAplicado.Monolito.API.Entities;

namespace XPe.PrjAplicado.Monolito.API.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>
    {
        public ClienteRepository(): base("clientes")
        {            
        }

        public Cliente Obter(Guid codigo)
        {
            return Dados.FirstOrDefault(C => C.Codigo == codigo);
        }

        public IList<Cliente> ObterLista()
        {
            return Dados.ToList();
        }

        public void Salvar(Cliente entidade)
        {
            Dados.Add(entidade);
            SaveChanges();
        }

        public void Atualizar(Guid codigo, Cliente entidade)
        {
            var registro = Dados.FirstOrDefault(C => C.Codigo == codigo);

            if (entidade != null)
            {
                Dados.Remove(registro);
                Dados.Add(entidade);
                SaveChanges();
            }
            else
            {
                throw new Exception("Dados não encontrados!");
            }                
        }

        public void Excluir(Guid codigo)
        {
            var entidade = Obter(codigo);

            if (entidade != null)
            {
                Dados.Remove(entidade);
                SaveChanges();
            }                
            else
            {
                throw new Exception("Dados não encontrados!");
            }
        }
    }
}