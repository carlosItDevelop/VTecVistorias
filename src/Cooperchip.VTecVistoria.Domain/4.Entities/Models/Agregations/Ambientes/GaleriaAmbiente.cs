﻿
using Cooperchip.VTecVistoria.DomainCore.Base;
using System;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambientes
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

        public virtual Ambiente Ambiente { get;  }
        
        /// <summary>
        /// ForeingKey para Id em Ambiente
        /// </summary>
        public Guid AmbienteId { get; private set; }

    }
}
