using System;
using System.Collections.Generic;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Repositories;
using XPe.PrjAplicado.Monolito.API.Services.Base;

namespace XPe.PrjAplicado.Monolito.API.Services
{
    public class ProdutoService : ServiceBase
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoService()
        {
            _produtoRepository = new ProdutoRepository();
        }

        public Produto Obter(Guid codigo)
        {
            return _produtoRepository.Obter(codigo);
        }

        public IList<Produto> ObterLista()
        {
            return _produtoRepository.ObterLista();
        }

        public void Salvar(Produto entidade)
        {
            if (entidade.EhValido())
                _produtoRepository.Salvar(entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }

        public void Atualizar(Guid codigo, Produto entidade)
        {
            entidade.Codigo = codigo;
            if (entidade.EhValido())
                _produtoRepository.Atualizar(codigo, entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }

        public void Excluir(Guid codigo)
        {
            _produtoRepository.Excluir(codigo);
        }
    }
}