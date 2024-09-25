using System;
using System.Collections.Generic;
using System.Web.Http;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Services;

namespace XPe.PrjAplicado.Monolito.API.Controllers
{
    [Route("api/v1/cliente")]
    public class ClienteController : ApiController
    {
        private readonly ClienteService _clienteService;

        public ClienteController()
        {
            _clienteService = new ClienteService();
        }

        [HttpGet]
        public IList<Cliente> Get()
        {
            return _clienteService.ObterLista();
        }

        [HttpGet]
        [Route("api/v1/cliente/{codigo}")]
        public Cliente Get(Guid codigo)
        {
            return _clienteService.Obter(codigo);
        }

        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            _clienteService.Salvar(cliente);
        }

        [HttpPut]
        public void Put(Guid codigo, [FromBody] Cliente cliente)
        {
            _clienteService.Atualizar(codigo, cliente);
        }

        [HttpDelete]
        public void Delete(Guid codigo)
        {
            _clienteService.Excluir(codigo);
        }
    }
}