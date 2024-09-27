using System.Collections.Generic;

namespace XPe.PrjAplicado.Interop.Services
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
