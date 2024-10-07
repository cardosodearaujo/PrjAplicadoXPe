using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Microsservico.Pedidos.API.Repositories.DbContext;
using XPe.PrjAplicado.Microsservico.Pedidos.API.Repositories.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Pedidos.API.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private IList<Pedido> Pedidos
        {
            get
            {
                return FakePedidoDbContext.Pedidos;
            }
        }

        public Pedido Obter(Guid codigo)
        {
            return Pedidos.FirstOrDefault(C => C.Codigo == codigo);
        }

        public IList<Pedido> ObterLista()
        {
            return Pedidos.ToList();
        }

        public void Salvar(Pedido entidade)
        {
            Pedidos.Add(entidade);
        }

        public void Atualizar(Guid codigo, Pedido entidade)
        {
            var registro = Pedidos.FirstOrDefault(C => C.Codigo == codigo);

            if (registro != null)
            {
                Pedidos.Remove(registro);
                Pedidos.Add(entidade);
            }
            else
            {
                throw new Exception("Dados não encontrados!");
            }
        }

        public void Excluir(Guid codigo)
        {
            var entidade = Obter(codigo);

            if (entidade != null)
            {
                Pedidos.Remove(entidade);
            }
            else
            {
                throw new Exception("Dados não encontrados!");
            }
        }
    }
}
