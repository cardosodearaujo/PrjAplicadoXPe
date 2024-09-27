using System;
using System.Collections.Generic;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Repositories;

namespace XPe.PrjAplicado.Monolito.API.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteService()
        {
            _clienteRepository = new ClienteRepository();
        }
        
        public Cliente Obter(Guid codigo)
        {
            return _clienteRepository.Obter(codigo);
        }
        
        public IList<Cliente> ObterLista()
        {
            return _clienteRepository.ObterLista();
        }
        
        public void Salvar(Cliente entidade)
        {
            _clienteRepository.Salvar(entidade);
        }
        
        public void Atualizar(Guid codigo, Cliente entidade)
        {
            _clienteRepository.Atualizar(codigo, entidade);
        }

        public void Excluir(Guid codigo)
        {
            _clienteRepository.Excluir(codigo);
        }
    }
}