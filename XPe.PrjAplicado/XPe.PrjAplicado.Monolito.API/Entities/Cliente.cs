using System;
using System.Linq;
using XPe.PrjAplicado.Monolito.API.Entities.Base;
using XPe.PrjAplicado.Monolito.API.Entities.Enumetators;

namespace XPe.PrjAplicado.Monolito.API.Entities
{
    public class Cliente : EntityBase
    {
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public TipoClienteEnum? TipoCliente { get; set; }
        public string CpfCnpj { get; set; }

        public override bool EhValido()
        {
            if (Codigo == Guid.Empty)
            {
                Mensagens.Add("O codigo do cliente é obrigatório");
            }

            if (string.IsNullOrEmpty(Nome))
            {
                Mensagens.Add("O nome do cliente é obrigatório");
            }

            if (TipoCliente is null)
            {
                Mensagens.Add("O tipo de cliente é obrigatório");
            }

            if (string.IsNullOrEmpty(CpfCnpj))
            {
                Mensagens.Add("O CPF/CNPJ do cliente é obrigatório");
            }

            return !Mensagens.Any();
        }
    }
}