using XPe.PrjAplicado.Interop.Entities;

namespace XPe.PrjAplicado.Microsservico.Pedidos.API.Repositories.DbContext
{
    public static class FakePedidoDbContext
    {
        public static IList<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
