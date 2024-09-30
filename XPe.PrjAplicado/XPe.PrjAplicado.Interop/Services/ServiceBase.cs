using System.Collections.Generic;
using XPe.PrjAplicado.Interop.Services.Interfaces;

namespace XPe.PrjAplicado.Interop.Services
{
    public class ServiceBase: IServiceBase
    {
        public List<string> Mensagens { get; set; }

        public ServiceBase()
        {
            Mensagens = new List<string>();
        }
    }
}
