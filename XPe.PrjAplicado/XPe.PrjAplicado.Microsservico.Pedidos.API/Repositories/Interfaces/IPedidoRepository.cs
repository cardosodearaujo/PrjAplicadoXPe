using XPe.PrjAplicado.Interop.Entities;

namespace XPe.PrjAplicado.Microsservico.Pedidos.API.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        Pedido Obter(Guid codigo);

        IList<Pedido> ObterLista();

        void Salvar(Pedido entidade);

        void Atualizar(Guid codigo, Pedido entidade);

        void Excluir(Guid codigo);
    }
}
