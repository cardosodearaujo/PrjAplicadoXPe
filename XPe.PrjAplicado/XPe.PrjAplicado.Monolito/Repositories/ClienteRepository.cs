using System;
using System.Collections.Generic;
using System.Linq;
using XPe.PrjAplicado.Monolito.API.Entities;

namespace XPe.PrjAplicado.Monolito.API.Repositories
{
    public class ClienteRepository
    {
        private IList<Cliente> _dados;

        public ClienteRepository()
        {
            _dados = new List<Cliente>();
        }

        public Cliente Obter(Guid codigo)
        {
            return _dados.FirstOrDefault(C => C.Codigo == codigo);
        }

        public IList<Cliente> ObterLista()
        {
            return _dados.ToList();
        }

        public void Salvar(Cliente cliente)
        {
            _dados.Add(cliente);
        }

        public void Atualizar(Guid codigo, Cliente cliente)
        {
            var entidade = _dados.FirstOrDefault(C => C.Codigo == codigo);

            if (entidade != null)
                entidade = cliente;
            else 
                throw new Exception("Dados não encontrados!");
        }

        public void Excluir(Guid codigo)
        {
            var entidade = Obter(codigo);

            if (entidade != null)
                _dados.Remove(entidade);
            else
                throw new Exception("Dados não encontrados!");
        }
    }
}