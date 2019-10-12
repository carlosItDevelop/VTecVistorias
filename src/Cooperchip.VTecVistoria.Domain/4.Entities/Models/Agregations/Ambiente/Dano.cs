
using Cooperchip.VTecVistoria.Domain._4.Entities.Base;
using System;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambiente
{
    public class Dano : EntityBase
    {
        public Dano(string nome, Guid AmbienteId)
        {
            this.Nome = nome;
            this.AmbienteId = AmbienteId;
        }

        public string Nome { get; private set; }
        public Guid AmbienteId { get; set; }
        public Ambiente Ambiente { get; set; }
    }
}
