using System;
using System.Collections.Generic;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Repositories;
using XPe.PrjAplicado.Monolito.API.Services.Base;

namespace XPe.PrjAplicado.Monolito.API.Services
{
    public class PedidoService : ServiceBase
    {
        private readonly PedidoRepository _pedidoRepository;

        public PedidoService()
        {
            _pedidoRepository = new PedidoRepository();
        }

        public Pedido Obter(Guid codigo)
        {
            return _pedidoRepository.Obter(codigo);
        }

        public IList<Pedido> ObterLista()
        {
            return _pedidoRepository.ObterLista();
        }

        public void Salvar(Pedido entidade)
        {
            if (entidade.EhValido())
                _pedidoRepository.Salvar(entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }

        public void Atualizar(Guid codigo, Pedido entidade)
        {
            entidade.Codigo = codigo;
            if (entidade.EhValido()) 
                _pedidoRepository.Atualizar(codigo, entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }

        public void Excluir(Guid codigo)
        {
            _pedidoRepository.Excluir(codigo);
        }
    }
}