using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Pedidos.API.Services.Interfaces
{
    public interface IPedidoService: IServiceBase
    {
        Pedido Obter(Guid codigo);

        IList<Pedido> ObterLista();

        void Salvar(Pedido entidade);

        void Atualizar(Guid codigo, Pedido entidade);

        void Excluir(Guid codigo);
    }
}
