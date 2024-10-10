using System;
using System.Web.Http;
using XPe.PrjAplicado.Interop.Controllers;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Services;
using ApiControllerBase = XPe.PrjAplicado.Monolito.API.Controllers.Base.ApiControllerBase;

namespace XPe.PrjAplicado.Monolito.API.Controllers
{
    [Route("api/v1/pedido")]
    public class PedidoController : ApiControllerBase, IMigrationController<IHttpActionResult, Pedido, Guid>
    {
        private readonly PedidoService _pedidoService;

        public PedidoController()
        {
            _pedidoService = new PedidoService();
        }

        //Obtém o pedido pelo código
        [HttpGet]
        public IHttpActionResult Get()
        {
            var lista = _pedidoService.ObterLista();
            return ProcessarRetorno(_pedidoService.Mensagens, lista);
        }

        //Obtém todos os pedidos   
        [HttpGet]
        [Route("api/v1/pedido/{codigo}")]
        public IHttpActionResult Get(Guid codigo)
        {
            var entidade = _pedidoService.Obter(codigo);
            return ProcessarRetorno(_pedidoService.Mensagens, entidade);
        }

        //Salva um pedido
        [HttpPost]
        public IHttpActionResult Post(Pedido entidade)
        {
            _pedidoService.Salvar(entidade);
            return ProcessarRetorno(_pedidoService.Mensagens);            
        }

        //Atualiza um pedido
        [HttpPut]
        public IHttpActionResult Put(Guid codigo, Pedido entidade)
        {
            _pedidoService.Atualizar(codigo, entidade);
            return ProcessarRetorno(_pedidoService.Mensagens);
        }

        //Exclui um pedido pelo código
        [HttpDelete]
        public IHttpActionResult Delete(Guid codigo)
        {
            _pedidoService.Excluir(codigo);
            return ProcessarRetorno(_pedidoService.Mensagens);
        }
    }
}