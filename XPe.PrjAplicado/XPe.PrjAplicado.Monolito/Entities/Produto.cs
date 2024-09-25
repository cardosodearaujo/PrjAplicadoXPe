using System;

namespace XPe.PrjAplicado.Monolito.API.Entities
{
    public class Produto
    {
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}