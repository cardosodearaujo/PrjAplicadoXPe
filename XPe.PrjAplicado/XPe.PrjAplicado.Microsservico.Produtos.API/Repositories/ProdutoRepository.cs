using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Repositories;
using XPe.PrjAplicado.Microsservico.Produtos.API.Repositories.DbContext;
using XPe.PrjAplicado.Microsservico.Produtos.API.Repositories.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Produtos.API.Repositories
{
    public class ProdutoRepository: BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository() : base("produtos")
        {
        }

        public Produto Obter(Guid codigo)
        {
            return Dados.FirstOrDefault(C => C.Codigo == codigo);
        }

        public IList<Produto> ObterLista()
        {
            return Dados.ToList();
        }

        public void Salvar(Produto entidade)
        {
            Dados.Add(entidade);
            SaveChanges();
        }

        public void Atualizar(Guid codigo, Produto entidade)
        {
            var registro = Dados.FirstOrDefault(C => C.Codigo == codigo);

            if (registro != null)
            {
                Dados.Remove(registro);
                Dados.Add(entidade);
                SaveChanges();
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
                Dados.Remove(entidade);
                SaveChanges();
            }
            else
            {
                throw new Exception("Dados não encontrados!");
            }
        }
    }
}
