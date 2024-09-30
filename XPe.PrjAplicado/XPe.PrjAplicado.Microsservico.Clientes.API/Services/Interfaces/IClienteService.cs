using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Interop.Services.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Clientes.API.Services.Interfaces
{
    public interface IClienteService: IServiceBase
    {
        Cliente Obter(Guid codigo);

        IList<Cliente> ObterLista();

        void Salvar(Cliente entidade);

        void Atualizar(Guid codigo, Cliente entidade);

        void Excluir(Guid codigo);
    }
}
