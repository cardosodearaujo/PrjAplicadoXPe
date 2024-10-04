using System;
using System.Linq;
using XPe.PrjAplicado.Interop.Entities.Base;

namespace XPe.PrjAplicado.Interop.Entities
{
    public class Produto: EntityBase
    {
        public Produto()
        {
            Codigo = Guid.NewGuid();
        }

        public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public override bool EhValido()
        {
            NomeEhValido();
            ValorEhValido();
            return !Mensagens.Any();
        }

        public bool CodigoEhValido()
        {
            if (Codigo == Guid.Empty)
            {
                Mensagens.Add("O campo código é obrigatório");
            }
            return !Mensagens.Any();
        }

        public bool NomeEhValido()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                Mensagens.Add("O nome do produto é obrigatório");
            }
            return !Mensagens.Any();
        }

        public bool ValorEhValido()
        {
            if (Valor <= 0)
            {
                Mensagens.Add("O valor do produto é obrigatório");
            }
            return !Mensagens.Any();
        }
    }
}
