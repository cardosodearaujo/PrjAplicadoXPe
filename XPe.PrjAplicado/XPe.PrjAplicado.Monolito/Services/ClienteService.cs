using System;
using System.Collections.Generic;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Repositories;
using XPe.PrjAplicado.Monolito.API.Services.Base;

namespace XPe.PrjAplicado.Monolito.API.Services
{
    public class ClienteService : ServiceBase
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
            if (entidade.EhValido())
                _clienteRepository.Salvar(entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }
        
        public void Atualizar(Guid codigo, Cliente entidade)
        {
            if (entidade.EhValido())
                _clienteRepository.Atualizar(codigo, entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }

        public void Excluir(Guid codigo)
        {
            _clienteRepository.Excluir(codigo);
        }
    }
}