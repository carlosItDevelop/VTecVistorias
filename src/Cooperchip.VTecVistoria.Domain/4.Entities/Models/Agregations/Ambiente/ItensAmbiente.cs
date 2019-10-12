using System;
using System.Collections.Generic;
using System.Text;
using Cooperchip.VTecVistoria.Domain._4.Entities.Base;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambiente
{
    public class ItensAmbiente : EntityBase
    {
        public ItensAmbiente(string nome, Guid ambienteId)
        {
            this.Nome = nome;
            this.AmbienteId = ambienteId;
        }

        public string Nome { get; private set; }
        
        public Guid AmbienteId { get; private set; }
        public Ambiente Ambiente { get; set; }
    }
}
