using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services;
using XPe.PrjAplicado.Microsservico.Pedidos.API.Repositories.Interfaces;
using XPe.PrjAplicado.Microsservico.Pedidos.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Pedidos.API.Services
{
    public class PedidoService : ServiceBase, IPedidoService
    {
        private readonly IPedidoRepository _produtoRepository;

        public PedidoService(IPedidoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Pedido Obter(Guid codigo)
        {
            var entidade = new Pedido { Codigo = codigo };

            if (entidade.CodigoEhValido())
                return _produtoRepository.Obter(codigo);

            Mensagens.AddRange(entidade.Mensagens);

            return null;
        }

        public IList<Pedido> ObterLista()
        {
            return _produtoRepository.ObterLista();
        }

        public void Salvar(Pedido entidade)
        {
            if (entidade.EhValido())
                _produtoRepository.Salvar(entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }

        public void Atualizar(Guid codigo, Pedido entidade)
        {
            entidade.Codigo = codigo;

            if (entidade.EhValido())
                _produtoRepository.Atualizar(codigo, entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }

        public void Excluir(Guid codigo)
        {
            var entidade = new Pedido { Codigo = codigo };

            if (entidade.CodigoEhValido())
                _produtoRepository.Excluir(codigo);

            Mensagens.AddRange(entidade.Mensagens);
        }
    }
}
