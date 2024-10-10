using System.Collections.Generic;

namespace XPe.PrjAplicado.Monolito.API.Entities.Base
{
    public abstract class EntityBase
    {   
        public List<string> Mensagens { get; set; }

        public EntityBase()
        {
           Mensagens = new List<string>();  
        }

        public abstract bool EhValido();
    }
}