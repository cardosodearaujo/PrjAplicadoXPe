using XPe.PrjAplicado.Microsservico.Produtos.API.Repositories;
using XPe.PrjAplicado.Microsservico.Produtos.API.Repositories.Interfaces;
using XPe.PrjAplicado.Microsservico.Produtos.API.Services;
using XPe.PrjAplicado.Microsservico.Produtos.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Produtos.API.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void InjetarDependencias(this IServiceCollection services)
        {
            
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
