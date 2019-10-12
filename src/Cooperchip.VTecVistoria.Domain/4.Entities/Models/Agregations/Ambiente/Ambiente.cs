
using Cooperchip.VTecVistoria.Domain._4.Entities.Base;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambiente
{
    public class Ambiente : EntityBase
    {
        public Ambiente()
        {
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public GaleriaAmbiente GaleriaAmbiente { get; set; }
        public ItensAmbiente ItensAmbiente { get; set; }
        public MobiliaAmbiente MobiliaAmbiente { get; set; }
        public Dano Dano { get; set; }

        public string NomeCompleto()
        {
            return this.Nome + " " + this.Sobrenome;
        }
    }

}
