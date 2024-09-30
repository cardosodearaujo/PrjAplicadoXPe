using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Produtos.API.Services.Interfaces
{
    public interface IProdutoService: IServiceBase
    {

        Produto Obter(Guid codigo);

        IList<Produto> ObterLista();

        void Salvar(Produto entidade);

        void Atualizar(Guid codigo, Produto entidade);

        void Excluir(Guid codigo);
    }
}
