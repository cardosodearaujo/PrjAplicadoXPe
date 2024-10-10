using System;
using System.Linq;
using XPe.PrjAplicado.Interop.Entities.Base;

namespace XPe.PrjAplicado.Interop.Entities
{
    public class PedidoItem: EntityBase
    {
        public Guid CodigoPedido { get; set; }
        public Guid CodigoItem { get; set; }
        public Guid CodigoProduto { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorTotal { get; set; }

        public override bool EhValido()
        {
            CodigoPedidoEhValido();
            CodigoItemEhValido();
            CodigoProdutoEhValido();
            ValorUnitarioEhValido();
            QuantidadeEhValido();
            ValorTotalEhValido();
            return !Mensagens.Any();
        }

        public bool CodigoPedidoEhValido()
        {
            if (CodigoPedido == Guid.Empty)
            {
                Mensagens.Add("O campo código do pedido é obrigatório.");
            }

            return Mensagens.Any();
        }

        public bool CodigoItemEhValido()
        {
            if (CodigoItem == Guid.Empty)
            {
                Mensagens.Add("O campo código do item é obrigatório.");
            }

            return Mensagens.Any();
        }

        public bool CodigoProdutoEhValido()
        {
            if (CodigoProduto == Guid.Empty)
            {
                Mensagens.Add("O código do produto é obrigatório!");
            }

            return Mensagens.Any();
        }

        public bool ValorUnitarioEhValido()
        {
            if (ValorUnitario <= 0)
            {
                Mensagens.Add("É obrigatório informar o valor unitário!");
            }

            return Mensagens.Any();
        }

        public bool QuantidadeEhValido()
        {
            if (ValorUnitario <= 0)
            {
                Mensagens.Add("É obrigatório informar a quantidade!");
            }

            return Mensagens.Any();
        }

        public bool ValorTotalEhValido()
        {
            var valorTotal = Quantidade * ValorUnitario;

            if (valorTotal <= 0)
            {
                Mensagens.Add("O valor total do item não pode ser menor ou igual a zero!");
            }
            else
            {
                ValorTotal = valorTotal;
            }

            return Mensagens.Any();
        }
       
    }
}
