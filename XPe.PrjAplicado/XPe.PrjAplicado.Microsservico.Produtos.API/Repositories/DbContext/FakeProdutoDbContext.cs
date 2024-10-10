using XPe.PrjAplicado.Interop.Entities;

namespace XPe.PrjAplicado.Microsservico.Produtos.API.Repositories.DbContext
{
    public static class FakeProdutoDbContext
    {
        public static IList<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
