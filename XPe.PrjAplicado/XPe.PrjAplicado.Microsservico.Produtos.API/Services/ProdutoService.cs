using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services;
using XPe.PrjAplicado.Microsservico.Produtos.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Produtos.API.Services
{
    public class ProdutoService: ServiceBase, IProdutoService
    {
        public Produto Obter(Guid codigo)
        {
            return null;
        }

        public IList<Produto> ObterLista()
        {
            return null;
        }

        public void Salvar(Produto entidade)
        {
            
        }

        public void Atualizar(Guid codigo, Produto entidade)
        {
            
        }

        public void Excluir(Guid codigo)
        {
            
        }
    }
}
