# Repositório Oficial do Projeto VTec Vistoria - Refactory - out-2019

### Início do refatoramento do projeto: 12/10/2019 - Fim do refatoramanto: 28/10/2019

```
> Imagem da Tela Inicial - Caso de Uso de Terceiros
```

![Tela Inicial do Sistema VTecVistoria-Sys](http://apimltools.com.br/vtecvistoriaimg/apresentacao-devolus1280x720.png "Apresentação Devolus")

```
> Funcionalidades - Caso de Uso de Terceiros
```

![Tela de Funcionalidades do VTecVistoria-Sys](http://apimltools.com.br/vtecvistoriaimg/funcionalidades.png "Apresentação Devolus")

```
> Código primário da Agregação Ambiente
```

```CShap

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

```
