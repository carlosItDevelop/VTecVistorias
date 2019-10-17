using System.Collections.Generic;
using Cooperchip.VTecVistoria.Domain._4.Entities.Base;
using Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambientes;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Imobiliarias
{
    public class Vistoria : EntityBase
    {
        public Vistoria()
        {
            
        }

        public string Descricao { get; set; }
        public ICollection<Ambiente> Ambientes { get; set; }
    }
}
