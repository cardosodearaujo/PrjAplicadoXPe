using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services;
using XPe.PrjAplicado.Microsservico.Clientes.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Clientes.API.Services
{
    public class ClienteService : ServiceBase, IClienteService
    {
        public void Atualizar(Guid codigo, Cliente entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid codigo)
        {
            throw new NotImplementedException();
        }

        public Cliente Obter(Guid codigo)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> ObterLista()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Cliente entidade)
        {
            throw new NotImplementedException();
        }
    }
}
