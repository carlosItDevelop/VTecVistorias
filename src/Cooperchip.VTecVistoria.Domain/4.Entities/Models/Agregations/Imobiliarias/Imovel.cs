using System;
using System.Collections.Generic;
using System.Text;
using Cooperchip.VTecVistoria.DomainCore.Base;

namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Imobiliarias
{
    public class Imovel : EntityBase
    {
        protected Imovel(string nome, Guid imobiliariaId, Guid locadorId, Guid locatarioId, bool isLocado)
        {
            Nome = nome;
            ImobiliariaId = imobiliariaId;
            LocadorId = locadorId;
            LocatarioId = locatarioId;
            IsLocado = isLocado;
        }

        public string Nome { get; private set; }

        public Guid ImobiliariaId { get; private set; }
        public Imobiliaria Imobiliaria { get; private set; }

        public Guid LocadorId { get; private set; }
        public Locador Locador { get; private set; }

        public Guid LocatarioId { get; private set; }
        public Locatario Locatario { get; private set; }

        public bool IsLocado { get; private set; }

        // AdRok
        public void Locar() => IsLocado = true;
        public void Deslocar() => IsLocado = false;
    }
}
