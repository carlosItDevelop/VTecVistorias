
using System;
using System.Collections.Generic;
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
        public ICollection<ItensAmbiente> ItensAmbientes { get; set; }
        public ICollection<MobiliaAmbiente> MobiliaAmbientes { get; set; }
        public ICollection<Dano> Danos { get; set; }

        public string NomeCompleto()
        {
            return this.Nome + " " + this.Sobrenome;
        }

        public void AddItems(string nome, Guid AmbienteId)
        {
            ItensAmbiente item = new ItensAmbiente(nome, AmbienteId);
            ItensAmbientes.Add(item);
        }

        public void AddGaleria()
        {

        }

    }

}
