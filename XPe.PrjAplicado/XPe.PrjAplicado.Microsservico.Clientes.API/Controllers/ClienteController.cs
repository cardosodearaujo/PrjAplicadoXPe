using Microsoft.AspNetCore.Mvc;
using XPe.PrjAplicado.Interop.Controllers;
using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services;

namespace XPe.PrjAplicado.Microsservico.Clientes.API.Controllers
{
    [Route("api/v1/cliente")]
    public class ClienteController : ApiControllerBase, IMigrationController<ActionResult, Cliente, Guid>
    {
        [HttpGet("{codigo}")]
        public ActionResult Get(Guid codigo)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult Get()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Post(Cliente entidade)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult Put(Guid codigo, Cliente entidade)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult Delete(Guid codigo)
        {
            throw new NotImplementedException();
        }
    }
}
