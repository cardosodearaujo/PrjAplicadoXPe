using System;
using System.Linq;
using XPe.PrjAplicado.Monolito.API.Entities.Base;

namespace XPe.PrjAplicado.Monolito.API.Entities
{
    public class Produto : EntityBase
    {
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public override bool EhValido()
        {
            if (Codigo == Guid.Empty)
            {
                Mensagens.Add("O código do produto é obrigatório");
            }

            if (string.IsNullOrEmpty(Nome))
            {
                Mensagens.Add("O nome do produto é obrigatório");
            }

            if (Valor <= 0)
            {
                Mensagens.Add("O valor do produto é obrigatório");
            }

            return !Mensagens.Any();
        }
    }
}