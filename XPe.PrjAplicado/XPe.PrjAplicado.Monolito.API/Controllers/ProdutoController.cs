using System.Collections.Generic;
using System;
using System.Web.Http;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Services;

namespace XPe.PrjAplicado.Monolito.API.Controllers
{
    [Route("api/v1/produto")]
    public class ProdutoController : ApiController
    {
        private readonly ProdutoService _produtoService;

        public ProdutoController()
        {
            _produtoService = new ProdutoService();
        }

        //Obtém o produto pelo código
        [HttpGet]
        public IList<Produto> Get()
        {
            return _produtoService.ObterLista();
        }

        //Obtém todos os produtos 
        [HttpGet]
        [Route("api/v1/produto/{codigo}")]
        public Produto Get(Guid codigo)
        {
            return _produtoService.Obter(codigo);
        }

        //Salva um produto
        [HttpPost]
        public void Post([FromBody] Produto entidade)
        {
            _produtoService.Salvar(entidade);
        }

        //Atualiza um produto
        [HttpPut]
        public void Put(Guid codigo, [FromBody] Produto entidade)
        {
            _produtoService.Atualizar(codigo, entidade);
        }

        //Exclui um produto pelo código
        [HttpDelete]
        public void Delete(Guid codigo)
        {
            _produtoService.Excluir(codigo);
        }
    }
}