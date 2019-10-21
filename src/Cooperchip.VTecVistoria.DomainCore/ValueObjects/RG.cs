using System;

namespace Cooperchip.VTecVistoria.DomainCore.ValueObjects
{
    public class RG
    {
        public string Numero { get; set; }
        public string Emissor { get; set; }
        public DateTime DataEmissao { get; set; }

        // Para o EF
        protected RG() { }
    }
}