using XPe.PrjAplicado.Interop.Entities;

namespace XPe.PrjAplicado.Microsservico.Clientes.API.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        Cliente Obter(Guid codigo);

        IList<Cliente> ObterLista();

        void Salvar(Cliente entidade);

        void Atualizar(Guid codigo, Cliente entidade);

        void Excluir(Guid codigo);
    }
}
