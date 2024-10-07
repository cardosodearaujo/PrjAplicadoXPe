using XPe.PrjAplicado.Microsservico.Pedidos.API.Repositories;
using XPe.PrjAplicado.Microsservico.Pedidos.API.Repositories.Interfaces;
using XPe.PrjAplicado.Microsservico.Pedidos.API.Services;
using XPe.PrjAplicado.Microsservico.Pedidos.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Pedidos.API.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void InjetarDependencias(this IServiceCollection services)
        {
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
        }
    }
}
