using System.Collections.Generic;
using XPe.PrjAplicado.Monolito.API.Entities;

namespace XPe.PrjAplicado.Monolito.API.Repositories.DbContext
{
    public static class FakePrjAplicadoDbContext
    {
        public static IList<Cliente> Clientes { get; set; } = new List<Cliente>();
        public static IList<Produto> Produtos { get; set; } = new List<Produto>();
        public static IList<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}