using Microsoft.AspNetCore.Mvc;
using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services;

namespace XPe.PrjAplicado.Microsservico.Pedidos.API.Controllers
{
    [Route("api/v1/pedido")]
    public class PedidoController : ApiControllerBase, IMigrationController<ActionResult, Pedido, Guid>
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
        public ActionResult Post(Pedido entidade)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult Put(Guid codigo, Pedido entidade)
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
