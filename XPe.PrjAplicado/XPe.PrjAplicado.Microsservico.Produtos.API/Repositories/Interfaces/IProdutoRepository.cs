using XPe.PrjAplicado.Interop.Entities;

namespace XPe.PrjAplicado.Microsservico.Produtos.API.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        Produto Obter(Guid codigo);

        IList<Produto> ObterLista();
        
        void Salvar(Produto entidade);
        
        void Atualizar(Guid codigo, Produto entidade);
        
        void Excluir(Guid codigo);
    }
}
