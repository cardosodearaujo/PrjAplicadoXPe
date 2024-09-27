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
        
        //Obtém o cliente pelo código
        [HttpGet]
        public IList<Cliente> Get()
        {
            return _clienteService.ObterLista();
        }

        //Obtém todos os clientes   
        [HttpGet]
        [Route("api/v1/cliente/{codigo}")]
        public Cliente Get(Guid codigo)
        {
            return _clienteService.Obter(codigo);
        }

        //Salva um cliente
        [HttpPost]
        public void Post([FromBody] Cliente entidade)
        {
            _clienteService.Salvar(entidade);
        }

        //Atualiza um cliente
        [HttpPut]
        public void Put(Guid codigo, [FromBody] Cliente entidade)
        {
            _clienteService.Atualizar(codigo, entidade);
        }

        //Exclui um cliente pelo código
        [HttpDelete]
        public void Delete(Guid codigo)
        {
            _clienteService.Excluir(codigo);
        }
    }
}