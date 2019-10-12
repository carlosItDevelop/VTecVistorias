# Repositório Oficial do Projeto VTec Vistoria - Refactory - out-2019

### Início do refatoramento do projeto: 12/10/2019 - Fim do refatoramanto: 28/10/2019


```
> Funcionalidades - Caso de Uso de Terceiros
```

![Tela de Funcionalidades do VTecVistoria-Sys](http://apimltools.com.br/vtecvistoriaimg/funcionalidades.png "Apresentação Devolus")

```
> Código primário da Agregação Ambiente
```

```CSharp

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
        public string Nome { get; set; }
        public string Subtitulo { get; set; }
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

```

```
> Controle Visual de Updates - Atualização de Commits
```

![Commit Update 0003 - VTecVistoria-Sys](http://apimltools.com.br/vtecvistoriaimg/commits-upd-0003.png "Atualização de Commits")

```CSharp

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

```
