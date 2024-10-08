using System;
using System.Web.Http;
using XPe.PrjAplicado.Interop.Controllers;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Services;
using ApiControllerBase = XPe.PrjAplicado.Monolito.API.Controllers.Base.ApiControllerBase;

namespace XPe.PrjAplicado.Monolito.API.Controllers
{
    [Route("api/v1/cliente")]
    public class ClienteController : ApiControllerBase, IMigrationController<IHttpActionResult, Cliente, Guid>
    {
        private readonly ClienteService _clienteService;

        public ClienteController()
        {
            _clienteService = new ClienteService();
        }
        
        //Obtém o cliente pelo código
        [HttpGet]
        public IHttpActionResult Get()
        {
            var lista = _clienteService.ObterLista();
            return ProcessarRetorno(_clienteService.Mensagens, lista);
        }

        //Obtém todos os clientes   
        [HttpGet]
        [Route("api/v1/cliente/{codigo}")]
        public IHttpActionResult Get(Guid codigo)
        {
            var entidade = _clienteService.Obter(codigo);
            return ProcessarRetorno(_clienteService.Mensagens, entidade);
        }

        //Salva um cliente
        [HttpPost]
        public IHttpActionResult Post(Cliente entidade)
        {
            _clienteService.Salvar(entidade);
            return ProcessarRetorno(_clienteService.Mensagens);
        }

        //Atualiza um cliente
        [HttpPut]
        public IHttpActionResult Put(Guid codigo, Cliente entidade)
        {
            _clienteService.Atualizar(codigo, entidade);
            return ProcessarRetorno(_clienteService.Mensagens);
        }

        //Exclui um cliente pelo código
        [HttpDelete]
        public IHttpActionResult Delete(Guid codigo)
        {
            _clienteService.Excluir(codigo);
            return ProcessarRetorno(_clienteService.Mensagens);
        }
    }
}