
using Cooperchip.VTecVistoria.DomainCore.Base;
using System;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambientes
{
    public class MobiliaAmbiente : EntityBase
    {
        public MobiliaAmbiente(string nome, Guid ambienteid)
        {
            this.Nome = nome;
            this.AmbienteId = ambienteid;
        }

        public string Nome { get; private set; }
        public Guid AmbienteId { get; private set; }
        public Ambiente Ambiente { get; set; }
    }
}
