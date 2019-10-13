# Repositório Oficial do Projeto VTec Vistoria - Refactory - out-2019

### Início do refatoramento do projeto: 12/10/2019 - Fim do refatoramanto: 28/10/2019



- Funcionalidades - Caso de Uso de Terceiros


![Tela de Funcionalidades do VTecVistoria-Sys](http://apimltools.com.br/vtecvistoriaimg/funcionalidades1280x720.png "Apresentação - VTecVistoria-Sys")


- Código primário da Agregação Ambiente

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
			public string Nome { get; private set; }
			public string Subtitulo { get; private set; }
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

```


- Controle Visual de Updates - Atualização de Commits

![Commit Update 0003 - VTecVistoria-Sys](http://apimltools.com.br/vtecvistoriaimg/commits-upd-0003.png "Atualização de Commits")


- Código primário de Dano, na Agregação Ambiente;
- Precisa receber um Nome para a instância e o Id do Ambiente;
- Pertence a um Ambiente, que é onde deve ser inserido ou removido;
- Seguindo o padrão de Domínio Rico no caso acima;


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

- Código primário: MobiliaAmbiente.

```CSharp

	using Cooperchip.VTecVistoria.Domain._4.Entities.Base;
	using System;

	namespace Cooperchip.VTecVistoria.Domain._4.Entities.Models.Agregations.Ambiente
	{
		public class MobiliaAmbiente : EntityBase
		{
			public MobiliaAmbiente(string nome, Guid ambienteid)
			{
				this.Nome = nome;
				this.AmbienteId = ambienteid;
			}

			public string Nome { get; private set; }
			public Guid AmbienteId { get; private set; }
			public Ambiente Ambiente { get; set; }
		}
	}

```


# Agregação Vistoria
### Nesta agregação ele é Object Root de Ambiente, que tem sua própria agregação bem desenhada

---

> Próximos passos:

* Agregar Vistoria com Ambiente, DadosGerais e Medidores
* Acima desta agregação, Vistoria é filha de Cliente (Imobiliaria)

**Atenção:** Cliente é quem tem os dados de Imovel, Locador e Locatario

```html
<h1>Usando HTML</h1>
```

```css
// Usando CSS
h1:after {
  content: 'using';
}
```

```js
// Usando JavaScript
console.log('WriteMe.md');
```

---

Consultar a documentação para TagHelpers e ViewComponents, **[Leia aqui](https://docs.microsoft.com/pt-br/)**.
Consultar a documentação para MarkDown, **[Leia aqui](http://daringfireball.net/projects/markdown/basics)**.
