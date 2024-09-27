using Microsoft.AspNetCore.Mvc;
using XPe.PrjAplicado.Interop.Controllers;
using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Microsservico.Produtos.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Produtos.API.Controllers
{
    [Route("api/v1/produto")]
    public class ProdutoController : ApiControllerBase, IMigrationController<IActionResult, Produto, Guid>
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("{codigo}")]
        public IActionResult Get(Guid codigo)
        {
            var entidade =_produtoService.Obter(codigo);
            return ProcessarRetorno(_produtoService.Mensagens, entidade);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var lista  = _produtoService.ObterLista();
            return ProcessarRetorno(_produtoService.Mensagens, lista);
        }

        [HttpPost]
        public IActionResult Post(Produto entidade)
        {
            _produtoService.Salvar(entidade);
            return ProcessarRetorno(_produtoService.Mensagens);
        }

        [HttpPut]
        public IActionResult Put(Guid codigo, Produto entidade)
        {
            _produtoService.Atualizar(codigo, entidade);
            return ProcessarRetorno(_produtoService.Mensagens);
        }

        [HttpDelete]
        public IActionResult Delete(Guid codigo)
        {
            _produtoService.Excluir(codigo);
            return ProcessarRetorno(_produtoService.Mensagens);
        }
    }
}
