using System;

namespace XPe.PrjAplicado.Monolito.API.Entities
{
    public class PedidoItem
    {
        public Guid CodigoPedido { get; set; }
        public Guid CodigoItem { get; set; }
        public Guid CodigoProduto { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
    }
}