using Microsoft.AspNetCore.Mvc;
using XPe.PrjAplicado.Interop.Controllers;
using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Microsservico.Pedidos.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Pedidos.API.Controllers
{
    [Route("api/v1/pedido")]
    public class PedidoController : ApiControllerBase, IMigrationController<IActionResult, Pedido, Guid>
    {
        public IPedidoService _pedidoService { get; set; }

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet("{codigo}")]
        public IActionResult Get(Guid codigo)
        {
            var entidade = _pedidoService.Obter(codigo);
            return ProcessarRetorno(_pedidoService.Mensagens, entidade);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var lista = _pedidoService.ObterLista();
            return ProcessarRetorno(_pedidoService.Mensagens, lista);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Pedido entidade)
        {
            _pedidoService.Salvar(entidade);
            return ProcessarRetorno(_pedidoService.Mensagens);
        }

        [HttpPut]
        public IActionResult Put(Guid codigo, [FromBody] Pedido entidade)
        {
            _pedidoService.Atualizar(codigo, entidade);
            return ProcessarRetorno(_pedidoService.Mensagens);
        }

        [HttpDelete]
        public IActionResult Delete(Guid codigo)
        {
            _pedidoService.Excluir(codigo);
            return ProcessarRetorno(_pedidoService.Mensagens);
        }
    }
}
