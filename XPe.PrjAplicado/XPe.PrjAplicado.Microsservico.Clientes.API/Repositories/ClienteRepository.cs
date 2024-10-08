using XPe.PrjAplicado.Interop.Entities;
using XPe.PrjAplicado.Microsservico.Clientes.API.Repositories.DbContext;
using XPe.PrjAplicado.Microsservico.Clientes.API.Repositories.Interfaces;

namespace XPe.PrjAplicado.Microsservico.Clientes.API.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private IList<Cliente> Clientes
        {
            get
            {
                return FakeClienteDbContext.Clientes;
            }
        }

        public List<string> Mensagens { get; set; }

        public Cliente Obter(Guid codigo)
        {
            return Clientes.FirstOrDefault(C => C.Codigo == codigo);
        }

        public IList<Cliente> ObterLista()
        {
            return Clientes.ToList();
        }

        public void Salvar(Cliente entidade)
        {
            Clientes.Add(entidade);
        }

        public void Atualizar(Guid codigo, Cliente entidade)
        {
            var registro = Clientes.FirstOrDefault(C => C.Codigo == codigo);

            if (entidade != null)
            {
                Clientes.Remove(registro);
                Clientes.Add(entidade);
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
                Clientes.Remove(entidade);
            }
            else
            {
                throw new Exception("Dados não encontrados!");
            }
        }
    }
}
