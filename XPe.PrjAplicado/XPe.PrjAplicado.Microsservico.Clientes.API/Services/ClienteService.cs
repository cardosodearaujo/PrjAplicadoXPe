using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services;
using XPe.PrjAplicado.Microsservico.Clientes.API.Repositories.Interfaces;
using XPe.PrjAplicado.Microsservico.Clientes.API.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Clientes.API.Services
{
    public class ClienteService : ServiceBase, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Atualizar(Guid codigo, Cliente entidade)
        {
            entidade.Codigo = codigo;

            if (entidade.EhValido())
                _clienteRepository.Atualizar(codigo, entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }

        public void Excluir(Guid codigo)
        {
            var entidade = new Cliente { Codigo = codigo };

            if (!entidade.CodigoEhValido())
                _clienteRepository.Excluir(codigo);

            Mensagens.AddRange(entidade.Mensagens);
        }

        public Cliente Obter(Guid codigo)
        {
            var entidade = new Cliente { Codigo = codigo };

            if (entidade.CodigoEhValido())
                return _clienteRepository.Obter(codigo);

            Mensagens.AddRange(entidade.Mensagens);

            return null;
        }

        public IList<Cliente> ObterLista()
        {
            return _clienteRepository.ObterLista();
        }

        public void Salvar(Cliente entidade)
        {
            if (entidade.EhValido())
                _clienteRepository.Salvar(entidade);

            Mensagens.AddRange(entidade.Mensagens);
        }
    }
}
