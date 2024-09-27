using XPe.PrjAplicado.Interop.Entities;

namespace XPe.PrjAplicado.Microsservico.Produtos.API.Services.Interfaces
{
    public interface IProdutoService
    {
        public List<string> Mensagens { get; set; }

        Produto Obter(Guid codigo);

        IList<Produto> ObterLista();

        void Salvar(Produto entidade);

        void Atualizar(Guid codigo, Produto entidade);

        void Excluir(Guid codigo);
    }
}
