using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XPe.PrjAplicado.Monolito.API.Entities;
using XPe.PrjAplicado.Monolito.API.Repositories.DbContext;

namespace XPe.PrjAplicado.Monolito.API.Repositories
{
    public class PedidoRepository
    {
        public IList<Pedido> Pedidos
        {
            get
            {
                return FakePrjAplicadoDbContext.Pedidos;
            }
        }

        public Pedido Obter(Guid codigo)
        {
            return Pedidos.FirstOrDefault(C => C.Codigo == codigo);
        }

        public IList<Pedido> ObterLista()
        {
            return Pedidos.ToList();
        }

        public void Salvar(Pedido entidade)
        {
            Pedidos.Add(entidade);
        }

        public void Atualizar(Guid codigo, Pedido entidade)
        {
            var registro = Pedidos.FirstOrDefault(C => C.Codigo == codigo);

            if (entidade != null)
            {
                Pedidos.Remove(registro);
                Pedidos.Add(entidade);
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
                Pedidos.Remove(entidade);
            }
            else
            {
                throw new Exception("Dados não encontrados!");
            }
        }
    }
}