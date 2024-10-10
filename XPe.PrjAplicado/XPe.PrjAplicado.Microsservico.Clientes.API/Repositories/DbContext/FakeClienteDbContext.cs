using XPe.PrjAplicado.Interop.Entities;

namespace XPe.PrjAplicado.Microsservico.Clientes.API.Repositories.DbContext
{
    public static class FakeClienteDbContext
    {
        public static IList<Cliente> Clientes { get; set; } = new List<Cliente>();
    }
}
