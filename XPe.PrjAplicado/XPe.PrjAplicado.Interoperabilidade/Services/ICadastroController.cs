using System;
using System.Collections.Generic;

namespace XPe.PrjAplicado.Interoperabilidade.Services
{
    public interface ICadastroController<Entidade>
    {
        Entidade Get(dynamic codigo);

        IList<Entidade> Get();

        void Post(Entidade entidade);

        void Put(dynamic codigo, Entidade entidade);

        void Delete(dynamic codigo);
    }
}
