using Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Imobiliarias;
using Cooperchip.VTecVistoria.DomainCore.Base;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using Cooperchip.VTecVistoria.DomainCore.Interface;


namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambientes
{
    public class Ambiente : EntityBase, IAggregateRoot
    {
        public Ambiente(string nome, string subtitulo, Guid vistoriaId)
        {
            this.Nome = nome;
            this.VistoriaId = vistoriaId;
            this.Subtitulo = (!string.IsNullOrEmpty(subtitulo)) ? this.Subtitulo = subtitulo : "";
        }
        public string Nome { get; private set; }
        public string Subtitulo { get; private set; }

        public Guid VistoriaId { get; private set; }
        public Vistoria Vistoria { get; private set; }

        public ICollection<ItensAmbiente> ItensAmbientes { get; private set; }
        public ICollection<MobiliaAmbiente> MobiliaAmbientes { get; private set; }
        public ICollection<Dano> Danos { get; private set; }

        public string NomeCompleto()
        {
            return Strings.Trim(this.Nome + " " + this.Subtitulo);
        }
        public void AddItems(string nome, Guid ambienteId)
        {
            ItensAmbiente item = new ItensAmbiente(nome, ambienteId);
            ItensAmbientes.Add(item);
        }
        public void AddIDanos(string nome, Guid ambienteId)
        {
            Dano item = new Dano(nome, ambienteId);
            Danos.Add(item);
        }

        public void AddGaleria()=> throw new NotImplementedException("Implemente o método!");
    }
}
