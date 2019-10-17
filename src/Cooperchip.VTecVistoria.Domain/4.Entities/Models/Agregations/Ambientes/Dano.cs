
using Cooperchip.VTecVistoria.Domain._4.Entities.Base;
using System;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambientes
{
    public class Dano : EntityBase
    {
        public Dano(string nome, Guid ambienteId)
        {
            this.Nome = nome;
            this.AmbienteId = ambienteId;
        }

        public string Nome { get; private set; }
        public Guid AmbienteId { get; private set; }
        public Ambiente Ambiente { get; set; }
    }
}
