using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services;
using XPe.PrjAplicado.Microsservico.Pedidos.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Pedidos.API.Services
{
    public class PedidoService : ServiceBase, IPedidoService
    {
        public void Atualizar(Guid codigo, Pedido entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid codigo)
        {
            throw new NotImplementedException();
        }

        public Pedido Obter(Guid codigo)
        {
            throw new NotImplementedException();
        }

        public IList<Pedido> ObterLista()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Pedido entidade)
        {
            throw new NotImplementedException();
        }
    }
}
