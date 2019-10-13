using System.Collections.Generic;
using Cooperchip.VTecVistoria.Domain._4.Entities.Base;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Vistorias
{
    public class Vistoria : EntityBase
    {
        public Vistoria()
        {
            
        }

        public string Descricao { get; set; }
        public ICollection<Ambiente.Ambiente> Ambientes { get; set; }
    }
}
