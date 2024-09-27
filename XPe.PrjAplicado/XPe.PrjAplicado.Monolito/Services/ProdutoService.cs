using System;
using System.Collections.Generic;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Repositories;

namespace XPe.PrjAplicado.Monolito.API.Services
{
    public class ProdutoService
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
            _produtoRepository.Salvar(entidade);
        }

        public void Atualizar(Guid codigo, Produto entidade)
        {
            _produtoRepository.Atualizar(codigo, entidade);
        }

        public void Excluir(Guid codigo)
        {
            _produtoRepository.Excluir(codigo);
        }
    }
}