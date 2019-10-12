using System;
using System.Collections.Generic;
using System.Text;
using Cooperchip.VTecVistoria.Domain._4.Entities.Base;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambiente
{
    public class ItensAmbiente : EntityBase
    {
        public ItensAmbiente(string nome, Guid AmbienteId)
        {
            this.Nome = nome;

        }

        public string Nome { get; private set; }
        
        
        public Guid AmbienteId { get; set; }
        public Ambiente Ambiente { get; set; }
    }
}
