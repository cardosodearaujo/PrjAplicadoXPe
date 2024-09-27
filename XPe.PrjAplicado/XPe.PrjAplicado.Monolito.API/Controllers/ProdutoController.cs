using System;
using System.Web.Http;
using XPe.PrjAplicado.Interop.Services;
using XPe.PrjAplicado.Monolito.API.Controllers.Base;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Services;

namespace XPe.PrjAplicado.Monolito.API.Controllers
{
    [Route("api/v1/produto")]
    public class ProdutoController : ControllerBase, IMigrationController<IHttpActionResult, Produto, Guid>
    {
        private readonly ProdutoService _produtoService;

        public ProdutoController()
        {
            _produtoService = new ProdutoService();
        }

        //Obtém o produto pelo código
        [HttpGet]
        public IHttpActionResult Get()
        {
            var lista = _produtoService.ObterLista();
            return ProcessarRetorno(_produtoService.Mensagens, lista);
        }

        //Obtém todos os produtos 
        [HttpGet]
        [Route("api/v1/produto/{codigo}")]
        public IHttpActionResult Get(Guid codigo)
        {
            var entidade = _produtoService.Obter(codigo);
            return ProcessarRetorno(_produtoService.Mensagens, entidade);
        }

        //Salva um produto
        [HttpPost]
        public IHttpActionResult Post([FromBody] Produto entidade)
        {
            _produtoService.Salvar(entidade);
            return ProcessarRetorno(_produtoService.Mensagens);
        }

        //Atualiza um produto
        [HttpPut]
        public IHttpActionResult Put(Guid codigo, [FromBody] Produto entidade)
        {
            _produtoService.Atualizar(codigo, entidade);
            return ProcessarRetorno(_produtoService.Mensagens);
        }

        //Exclui um produto pelo código
        [HttpDelete]
        public IHttpActionResult Delete(Guid codigo)
        {
            _produtoService.Excluir(codigo);
            return ProcessarRetorno(_produtoService.Mensagens);
        }
    }
}