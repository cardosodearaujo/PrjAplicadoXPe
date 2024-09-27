using System;
using System.Collections.Generic;

namespace XPe.PrjAplicado.Monolito.API.Entities
{
    public class Pedido
    {
        public Guid Codigo { get; set; }
        public Guid CodigoCliente { get; set; }
        public IList<PedidoItem> Itens { get; set; }
    }
}