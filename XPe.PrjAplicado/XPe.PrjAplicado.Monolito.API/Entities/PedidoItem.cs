using System;
using System.Linq;
using XPe.PrjAplicado.Monolito.API.Entities.Base;

namespace XPe.PrjAplicado.Monolito.API.Entities
{
    public class PedidoItem : EntityBase
    {

        public Guid CodigoPedido { get; set; }
        public Guid CodigoItem { get; set; }
        public Guid CodigoProduto { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorTotal { get; set; }

        public override bool EhValido()
        {
            if (CodigoPedido == Guid.Empty)
            {
                Mensagens.Add("O código do pedido é obrigatório!");
            }

            if (CodigoItem == Guid.Empty)
            {
                Mensagens.Add("O código do item é obrigatório!");
            }

            if (CodigoProduto == Guid.Empty)
            {
                Mensagens.Add("O código do cliente é obrigatório!");
            }

            if (ValorUnitario <= 0)
            {
                Mensagens.Add("É obrigatório informar o valor unitário!");
            }

            if (Quantidade <= 0)
            {
                Mensagens.Add("É obrigatório informar a quantidade!");
            }

            var valorTotal = Quantidade * ValorUnitario;

            if (valorTotal <= 0)
            {
                Mensagens.Add("O valor total do item não pode ser menor ou igual a zero!");
            }
            else
            {
                ValorTotal = valorTotal;
            }

            return !Mensagens.Any();
        }
    }
}