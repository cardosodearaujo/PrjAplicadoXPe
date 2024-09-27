using System.Collections.Generic;

namespace XPe.PrjAplicado.Monolito.API.Services.Base
{
    public class ServiceBase
    {
        public List<string> Mensagens { get; set; }

        public ServiceBase()
        {
            Mensagens = new List<string>(); 
        }
    }
}