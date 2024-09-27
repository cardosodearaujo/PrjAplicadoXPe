using Microsoft.AspNetCore.Mvc;
using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services;

namespace XPe.PrjAplicado.Microsservico.Produtos.API.Controllers
{
    [Route("api/v1/produto")]
    public class ProdutoController : Controller, IMigrationController<ActionResult, Produto, Guid>
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
        public ActionResult Post(Produto entidade)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult Put(Guid codigo, Produto entidade)
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
