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
        public Ambiente(string nome, string subtitulo)
        {
            this.Nome = nome;
            this.Subtitulo = (!string.IsNullOrEmpty(subtitulo)) ? this.Subtitulo = subtitulo : "";
        }
        public string Nome { get; private set; }
        public string Subtitulo { get; private set; }
        public Vistoria Vistoria { get; set; }

        // Todo: Este campo tem uma relação 0:1 com Galeria (Navewgação).
        // Todo: Ambiente pode ter uma Galeria, mas galeria sempre tem um Ambiente.
        public GaleriaAmbiente GaleriaAmbiente { get; set; }
        public ICollection<ItensAmbiente> ItensAmbientes { get; set; }
        public ICollection<MobiliaAmbiente> MobiliaAmbientes { get; set; }
        public ICollection<Dano> Danos { get; set; }

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
