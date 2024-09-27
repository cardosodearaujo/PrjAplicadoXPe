using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace XPe.PrjAplicado.Interop.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        public List<string> Mensagens { get; set; }

        public ApiControllerBase()
        {
            Mensagens = new List<string>();
        }

        protected IActionResult ProcessarRetorno(List<string> mensagens, dynamic retorno = null)
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
