using System.Linq;
using System;
using XPe.PrjAplicado.Interop.Entities.Base;
using XPe.PrjAplicado.Interop.Entities.Enumetators;

namespace XPe.PrjAplicado.Interop.Entities
{
    public class Cliente : EntityBase
    {
        public Cliente()
        {
            Codigo = Guid.NewGuid();
        }

        public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public TipoClienteEnum? TipoCliente { get; set; }
        public string CpfCnpj { get; set; }

        public override bool EhValido()
        {
            NomeEhValido();
            TipoClienteEhValido();
            CpfCnpjEhValido();

            return !Mensagens.Any();
        }

        public bool CodigoEhValido()
        {
            if (Codigo == Guid.Empty)
                Mensagens.Add("O código é obrigatório.");

            return !Mensagens.Any();
        }

        public bool NomeEhValido()
        {
            if (string.IsNullOrEmpty(Nome))
                Mensagens.Add("O nome do cliente é obrigatório.");

            return !Mensagens.Any();
        }

        public bool TipoClienteEhValido()
        {
            if (TipoCliente is null)
                Mensagens.Add("O tipo de cliente é obrigatório.");

            return !Mensagens.Any();
        }

        public bool CpfCnpjEhValido()
        {
            if (string.IsNullOrEmpty(CpfCnpj))
                Mensagens.Add("O CPF/CNPJ do cliente é obrigatório.");

            return !Mensagens.Any();
        }
    }
}
