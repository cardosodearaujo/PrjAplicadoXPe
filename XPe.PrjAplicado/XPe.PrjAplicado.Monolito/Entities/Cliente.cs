using System;
using XPe.PrjAplicado.Monolito.API.Enumerators;

namespace XPe.PrjAplicado.Monolito.API.Entities
{
    public class Cliente
    {
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public TipoClienteEnum TipoCliente { get; set; }
        public string CpfCnpj { get; set; }
    }
}