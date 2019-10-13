using System;
using System.Collections.Generic;
using System.Text;
using Cooperchip.VTecVistoria.Domain._4.Entities.Base;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambiente
{
    public class GaleriaAmbiente : EntityBase
    {
        /// <summary>
        /// Galeria sempre tem um Ambiente
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="ambienteId"></param>
        public GaleriaAmbiente(string nome, Guid ambienteId)
        {
            this.Nome = nome;
            this.AmbienteId = ambienteId;
        }

        public string Nome { get; private set; }

        public virtual Ambiente Ambiente { get; set; }
        
        /// <summary>
        /// ForeingKey para Id em Ambiente
        /// </summary>
        public Guid AmbienteId { get; set; }

    }
}
