using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Repositories;
using XPe.PrjAplicado.Microsservico.Pedidos.API.Repositories.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Pedidos.API.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository() : base("pedidos")
        {
        }


        public Pedido Obter(Guid codigo)
        {
            return Dados.FirstOrDefault(C => C.Codigo == codigo);
        }

        public IList<Pedido> ObterLista()
        {
            return Dados.ToList();
        }

        public void Salvar(Pedido entidade)
        {
            Dados.Add(entidade);
            SaveChanges();
        }

        public void Atualizar(Guid codigo, Pedido entidade)
        {
            var registro = Dados.FirstOrDefault(C => C.Codigo == codigo);

            if (registro != null)
            {
                Dados.Remove(registro);
                Dados.Add(entidade);
                SaveChanges();
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
                Dados.Remove(entidade);
                SaveChanges();
            }
            else
            {
                throw new Exception("Dados não encontrados!");
            }
        }
    }
}
