using Microsoft.AspNetCore.Mvc;
using XPe.PrjAplicado.Interop.Controllers;
using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Microsservico.Clientes.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Clientes.API.Controllers
{
    [Route("api/v1/cliente")]
    public class ClienteController : ApiControllerBase, IMigrationController<IActionResult, Cliente, Guid>
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet("{codigo}")]
        public IActionResult Get(Guid codigo)
        {
            var entidade = _clienteService.Obter(codigo);
            return ProcessarRetorno(_clienteService.Mensagens, entidade);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var entidade = _clienteService.ObterLista();
            return ProcessarRetorno(_clienteService.Mensagens, entidade);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente entidade)
        {
            _clienteService.Salvar(entidade);
            return ProcessarRetorno(_clienteService.Mensagens);
        }

        [HttpPut]
        public IActionResult Put(Guid codigo, [FromBody] Cliente entidade)
        {
            _clienteService.Atualizar(codigo, entidade);
            return ProcessarRetorno(_clienteService.Mensagens);
        }

        [HttpDelete]
        public IActionResult Delete(Guid codigo)
        {
            _clienteService.Excluir(codigo);
            return ProcessarRetorno(_clienteService.Mensagens);
        }
    }
}
