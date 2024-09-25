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

        public void Salvar(Cliente cliente)
        {
            _clienteRepository.Salvar(cliente);
        }

        public void Atualizar(Guid codigo, Cliente cliente)
        {
            _clienteRepository.Atualizar(codigo, cliente);
        }

        public void Excluir(Guid codigo)
        {
            _clienteRepository.Excluir(codigo);
        }
    }
}