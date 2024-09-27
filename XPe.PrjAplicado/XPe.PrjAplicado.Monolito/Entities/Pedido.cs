using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using XPe.PrjAplicado.Monolito.API.Entities.Base;

namespace XPe.PrjAplicado.Monolito.API.Entities
{
    public class Pedido : EntityBase
    {
        public Pedido()
        {
            Codigo = Guid.NewGuid();
        }

        public Guid Codigo { get; set; }
        public Guid CodigoCliente { get; set; }
        public IList<PedidoItem> Itens { get; set; }

        public override bool EhValido()
        {
            if (CodigoCliente == Guid.Empty)
            {
                Mensagens.Add("O código do cliente é obrigatório!");
            }

            if (Itens is null || !Itens.Any())
            {
                Mensagens.Add("Ao menos um item deve ser adicionado!");
            }
            else
            {
                Itens.ForEach(I =>
                {
                    I.EhValido();
                    Mensagens.AddRange(I.Mensagens);
                });
            }

            return !Mensagens.Any();
        }
    }
}