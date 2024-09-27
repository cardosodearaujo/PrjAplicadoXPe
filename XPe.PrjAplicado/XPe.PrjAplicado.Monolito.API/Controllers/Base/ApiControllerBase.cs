using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace XPe.PrjAplicado.Monolito.API.Controllers.Base
{
    public class ApiControllerBase : ApiController
    {
        public List<string> Mensagens { get; set; }

        public ApiControllerBase()
        {
            Mensagens = new List<string>();
        }

        protected IHttpActionResult ProcessarRetorno(List<string> mensagens, dynamic retorno = null)
        {
            if (!mensagens.Any())
            {
                if (retorno is null)
                    return Ok();
                else
                    return Ok(retorno);
            }
            else
            {
                return BadRequest(JsonConvert.SerializeObject(mensagens));
            }
        }
    }
}