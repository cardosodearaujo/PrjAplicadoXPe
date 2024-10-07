using XPe.PrjAplicado.Microsservico.Clientes.API.Repositories;
using XPe.PrjAplicado.Microsservico.Clientes.API.Repositories.Interfaces;
using XPe.PrjAplicado.Microsservico.Clientes.API.Services;
using XPe.PrjAplicado.Microsservico.Clientes.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Clientes.API.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void InjetarDependencias(this IServiceCollection services)
        {
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
        }
    }
}
