using System;
using System.Collections.Generic;
using System.Linq;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Repositories.DbContext;

namespace XPe.PrjAplicado.Monolito.API.Repositories
{
    public class ClienteRepository
    {
        public IList<Cliente> Clientes
        {
            get 
            { 
                return FakePrjAplicadoDbContext.Clientes; 
            }
        }

        public Cliente Obter(Guid codigo)
        {
            return Clientes.FirstOrDefault(C => C.Codigo == codigo);
        }

        public IList<Cliente> ObterLista()
        {
            return Clientes.ToList();
        }

        public void Salvar(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void Atualizar(Guid codigo, Cliente cliente)
        {
            var entidade = Clientes.FirstOrDefault(C => C.Codigo == codigo);

            if (entidade != null)
                entidade = cliente;
            else 
                throw new Exception("Dados não encontrados!");
        }

        public void Excluir(Guid codigo)
        {
            var entidade = Obter(codigo);

            if (entidade != null)
                Clientes.Remove(entidade);
            else
                throw new Exception("Dados não encontrados!");
        }
    }
}