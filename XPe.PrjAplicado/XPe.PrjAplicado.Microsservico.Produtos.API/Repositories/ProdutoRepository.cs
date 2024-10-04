using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Microsservico.Produtos.API.Repositories.DbContext;
using XPe.PrjAplicado.Microsservico.Produtos.API.Repositories.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Produtos.API.Repositories
{
    public class ProdutoRepository: IProdutoRepository
    {
        private IList<Produto> Produtos
        {
            get
            {
                return FakeProdutoDbContext.Produtos;
            }
        }

        public Produto Obter(Guid codigo)
        {
            return Produtos.FirstOrDefault(C => C.Codigo == codigo);
        }

        public IList<Produto> ObterLista()
        {
            return Produtos.ToList();
        }

        public void Salvar(Produto entidade)
        {
            Produtos.Add(entidade);
        }

        public void Atualizar(Guid codigo, Produto entidade)
        {
            var registro = Produtos.FirstOrDefault(C => C.Codigo == codigo);

            if (registro != null)
            {
                Produtos.Remove(registro);
                Produtos.Add(entidade);
            }
            else
            {
                throw new Exception("Dados não encontrados!");
            }
        }

        public void Excluir(Guid codigo)
        {
            var entidade = Obter(codigo);

            if (entidade != null)
            {
                Produtos.Remove(entidade);
            }
            else
            {
                throw new Exception("Dados não encontrados!");
            }
        }
    }
}
