using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services;
using XPe.PrjAplicado.Microsservico.Produtos.API.Repositories.Interfaces;
using XPe.PrjAplicado.Microsservico.Produtos.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Produtos.API.Services
{
    public class ProdutoService : ServiceBase, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto Obter(Guid codigo)
        {
            var entidade = new Produto { Codigo = codigo };

            if (entidade.CodigoEhValido())
                return _produtoRepository.Obter(codigo);
            
            Mensagens.AddRange(entidade.Mensagens);

            return null;
        }

        public IList<Produto> ObterLista()
        {
            return _produtoRepository.ObterLista();
        }

        public void Salvar(Produto entidade)
        {
            if (entidade.EhValido())
                _produtoRepository.Salvar(entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }

        public void Atualizar(Guid codigo, Produto entidade)
        {
            entidade.Codigo = codigo;

            if (entidade.EhValido())
                _produtoRepository.Atualizar(codigo, entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }

        public void Excluir(Guid codigo)
        {
            var entidade = new Produto { Codigo = codigo };

            if (!entidade.CodigoEhValido())
                _produtoRepository.Excluir(codigo);

            Mensagens.AddRange(entidade.Mensagens);
        }
    }
}
