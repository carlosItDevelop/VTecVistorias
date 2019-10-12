
using Cooperchip.VTecVistoria.Domain._4.Entities.Base;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambiente
{
    public class Ambiente : EntityBase
    {
        public Ambiente(string nome, string subtitulo)
        {
            this.Nome = nome;
            this.Subtitulo = (!string.IsNullOrEmpty(subtitulo)) ? this.Subtitulo = subtitulo : "";
        }
        public string Nome { get; private set; }
        public string Subtitulo { get; private set; }
        public GaleriaAmbiente GaleriaAmbiente { get; set; }
        public ICollection<ItensAmbiente> ItensAmbientes { get; set; }
        public ICollection<MobiliaAmbiente> MobiliaAmbientes { get; set; }
        public ICollection<Dano> Danos { get; set; }

        public string NomeCompleto()
        {
            return Strings.LTrim(this.Nome + " " + this.Subtitulo);
        }
        public void AddItems(string nome, Guid AmbienteId)
        {
            ItensAmbiente item = new ItensAmbiente(nome, AmbienteId);
            ItensAmbientes.Add(item);
        }
        public void AddGaleria()=> throw new NotImplementedException("Implemente o método!");
    }
}
