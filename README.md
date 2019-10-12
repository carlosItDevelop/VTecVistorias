
#Repositório Oficial do Projeto VTec Vistoria - Reafact - out-2019

## Os dados abaixo usei como exemplo para as chamadas dos códigos Gits (provisório).

## Início do refatoramento do projeto: 12/10/2019 - Fim do refatoramanto: 28/10/2019


##Diário de Bordo e Tasklist do Sistema VTecVistoria-Sys;
### Lista de tarefas pendentes e releases do aplicativo:

```html
- [x] Criação do 1º Service no Angular, que passará a ser nosso Frontend (Modulo: Genérico) - mai/2016;
- [x] RederScript na _Layout.cshtml - @Scripts.Render("~/bundles/core") e @Scripts.Render("~/bundles/datatableswithtools"); 
na MasterPage resolveu o problema de travamento do menu na Lista Anticoagulante e deve recolver nas outras também sem a TableTools. (Modulo: _Laout.cshtml
) - mai/2016
- [ ] Usar o plugin FluentValidator. Não substituirá o FluentApi, 
	pois ele não modela dados no banco, mas é exelente para validação de regras de negócios!

- [X] Criar um modelo da tela de Acessogeral no Photoshop, pois o CRUD todo é feito 
	em uma única Action, portanto preciso de um modelo visual bem definido;
- [ ] Usar listagem (IEnumrable) de ApplicationUser(UserManager) e Claims, abusando do select2;
- [x] Desabilitar LazyLoading e Proxy no Context de Entities;
- [ ] LazyLoading e Proxy desabilitados não funcionaram adequadamente (REVISAR);

- [ ] Criar um controller AngularJS com as seguintes características;
	> Preciso selecionar Usuários (usar select2);
	> Preciso selecionar(optar) a função {UserBase e FunctionBase};
	> Preciso selecionar Claims em cada linha (adição);
	> Nos radio buttons de acesso : true => 'true';
	> Ao selecionar(optar) AllowAll todos são 'true';
	> Ao adicionar (preciso do button Add) abrir uma <div>, originalmente oculta, com as opções 
		e habilitar 'Atualizar Permissões';
	> Não existe excluir (a priori);


- [ ][x][ ][ ] - Menu - Migration - OnModelCreating: Usando Fluent API - Especialidade;
- [ ][x][ ][ ] - Menu - Migration - EspecialidadeValidator: Usando FluentValidation - Especialidade;

- [x] Migrando de int Id para Guid;
-----------------------------------
- [x] [x][x][x][x] - Prontuario: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - Dreno: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - Agendamento: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - ApresentacaoAjustes: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - AtbEmUso: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - AtbJaUtilizados: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - BalancoHidrico: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - ExameDeImagem: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - Endereco: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - Prescricao: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - ProntuarioPrecaucao: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - ResultadoExames: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] [x][x][x][x] - SinaisVitais: Excluir IdPaciente -> ForeignKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations
- [x] -> Chave Primária:
- [x] [x][x][x][x] - Paciente: Excluir PacienteId -> PrimaryKey para PacienteGuid -> Corrigir as chamadas nos métodos (int p/ Guig) -> Migrations

- [x] -> Métodos Afetados/Corrigidos: 
------------------------------------
- [x] ApiResources/GetApiProntuarioPorId(int id => Guid id);
- [x] Home/Buscar(int id => Guid id);
- [x] ApiResources/PacienteExists(int id => Guid id);
- [x] Home/BuscaPacienteMenuRight(int id => Guid id);
- [x] Prontuario/BuscaPaciente(int id => Guid id);
- [x] Prontuario/Index(int id => Guid id);
- [x] Home/GetApresentacaoAjustesPorId(int id => Guid id);
- [x] AtbEmUso/GetAtbemUsoPorId(int id => Guid id);
- [x] AtbJaUtilizado/getAtbJaUtilizadoPorId(int id => Guid id);
- [x] BalancoHidrico/GetBalancoHidricoPorId(int id => Guid id);
- [x] Prontuario/Index(int id => Guid id);
- [x] Endereco [Edit/Create];
- [x] Home/BuscarEndereco(int id => Guid id);
- [x] ExameDeImagem/GetExameDeImagemPorId(int id => Guid id);
- [x] ApiResources/GetProntuarioPrecaucaoPorIdPaciente(int id => Guid id);
- [x] TelefonePaciente/getTelefonePacientePorId(int id => Guid id);

- [x] Reescrever Prontuario do Zero, pois é necessário que cada prontuario seja um objeto independente e o mesmo é uma coleção em Paciente;
- [x] Adicionar, Listar e Alterar prontuarios de acordo com o paciente selecionado!
- [x] Se for chamado direto de menu, sem paciente selecionado, devem ser listados todos os prontuarios de todos os pacientes;

- [x] Mostrar Nome do Paciente que está sendo Incluído ou Editado;
- [x] Permitir Datas Nulas... Depois verificar se em algum caso tem de ser Not Null (Não pode ser em todos, pois tem casos em que a data fica inibida!
- [x] Ao listar um Fk e tentar ordenar com AngulaJS na coluna dele deve ser informada a notação correta. Ex.: "<th><a href="#" ng-click="ordenarPor('Paciente.Nome')">Paciente</a></th>", dentro do Model Prontuario;
- [x] Dados do Paciente, em Prontuario, devem ser populados implicitaente, pois Prontuario tem Paciente obrigatoriamente;
- [x] Mostrar dados de Endereço em Prontuario;
- [x] Carregamento de dreno tem de funcionar em Prontuario, através de uma simulação de Click()
- [x] Carregamento de Telefones do Paciente tem de funcionar em Prontuario, através de uma simulação de Click()
- [x] Carregamento de AtbEmUso tem de funcionar em Prontuario, através de uma simulação de Click()
- [x] Carregamento de AtbJaUtilizado tem de funcionar em Prontuario, através de uma simulação de Click()
- [x] Carregamento de ProntuarioPrecaucao tem de funcionar em Prontuario, através de uma simulação de Click()
- [x] Mostrar Idade calculada em Paciente e Prontuario, para efeito demostrativo e para relatórios;
- [x] Gravar e ler data null em prontuário, quando necessário.
- [x] Carregar dados do paciente e seus telefones na adição de um novo prontuario!

- [x] Ao inibir preenchimento de datas, também torná-las nulas;

- [x] Replicar a técnica de carregamento através da simulação do evento click() para TelefonePaciente, AtbEmUso, AtbJaUtilizado e Dreno também na adição de novo Prontuario;

- [x] Verificar a função genérica que inibe data para corrigir uns testes que fiz;

- [x] excluir BuscaPaciente de Prontuario MVC - (Subtituído pela implementação WebAPI c/Service usando $http);
- [x] excluir AddProntuario de Prontuario MVC - (Subtituído pela implementação WebAPI c/Service usando $http);
- [x] excluir DelProntuario de Prontuario MVC - (Subtituído pela implementação WebAPI c/Service usando $http);
- [x] Excluir a função getInibirData no controller AngulaJS pronturio;

- [ ] Refactory de Prescricao;
- [x] Criar ObterPrescricaoPorId (este id é da Prescricao) em ApiResources;
- [x] Criar ObterTodasAsPrescricoes (passando o Guid? do Paciente) em ApiResources;
- [x] Excluir as ActionResults equivalentes (mvcController), pois usaremos as 2 acima (apiController);
- [x] Criar o Service: servicePrescricao, pois usaremos services com o $http injection;
- [x] Injetar pacienteService e prescricaoService no controller AngulaJS de Prescricao;
- [x] Registrar no BundleConfig o Service prescricaoService;
- [x] Passar o Model IEnumerable<.../Prescricao> para a Index de Prescricao;
- [x] Usar a diretiva AngulaJS: ng-init="init(@Newtonsoft.Json.JsonConvert.SerializeObject(Model))"> para o Model prescricao receber os dados serializados;
- [x] Criar no Controler AngulaJS de prescricao a função ng-click="incluirPrescricaoDiv(prescricao.PacienteGuid)"
- [x] Criar no Controler AngulaJS de prescricao a função ng-click="carregaPrescricaoPorId(prescricao)"
- [x] Criar no Controler AngulaJS de prescricao a função ng-click="ArquivarPrescricao(prescricao)"
- [x] Excluir a função ctrlGetPaciente de Prescricao, pois não preciso mais selecionar o paciente, visto que ele vem da lista suspensa;

- [x] Criar a função buscaEnderecoPaciente em Prescricao;
- [x] Criar o campo NumAtendimento em prescricao;
- [ ][x][ ] Popular para testes NumAtendimento / Prescricao -> (Depois validar esse modelo, pois meparece que este campo deveria ser apenas de prontuario);
- [x] Corrigir TyFluimicilGotasPe => FluimicilGotas;

- [ ] Implementar Exame de Imagens dentro de prontuario;
- [x] [x] Por ProntuarioGuid em EImagem;
- [x] [x] Vincular a tela de IEmagem ao Prontuario;
- [x] [x] Excluir ExameDeImagem.cshtml;
- [x] [x] Excluir arquivo ListaExameDeImagem;
- [x] [x] Excluir exame de Imagem do MenuLeft;
- [x] [x] Ajustar Exame de Imagem na Tela de prontuario, pois ele faz parte do mesmo;
- [x] [x] Substituir EImagem por ChamadaMedico na Tela Inicial;
- [ ] [ ] Trocar Imagem de EImagem por ChamadaMedico na Tela Inicial;
- [x] [x] Tornar Campo "PedidoEm" Nullable no objeto EImagem;
- [x] [x] Criar Prontuario Virtual no Objeto ExameDeImagem;
- [x] [x] Estilizar Tables com Class: table-hover, table-bordered;
- [x] [x] Estilizar th da View ExameDeImagem: class="alert alert-success";

- [x] Implementar BalançoHidrico e Sinais Vitais dentro de prontuario;
- [x] [x] Por ProntuarioGuid em BalancoHidrico;
- [x] [x] Vincular a tela de BHidrico ao Prontuario;
- [x] [x] Excluir BalancoHidrico.cshtml;
- [x] [x] Excluir arquivo ListaBalancoHidrico;
- [x] [x] Excluir BHidrico do MenuLeft;
- [x] [x] Ajustar BHidrico na Tela de prontuario, pois ele faz parte do mesmo;
- [x] [x] Substituir BHidrico por (item provisorio) na Tela Inicial;
- [ ] [ ] Trocar Imagem de BHidrico por (item provisorio) na Tela Inicial;
- [x] [x] Criar Prontuario Virtual no Objeto BHidrico;
- [x] [x] Estilizar Tables com Class: table-hover, table-bordered;
- [x] [x] Estilizar th da View BHidrico: class="alert alert-success";

- [x] Usar select2 em AtbEmUso e AtbJaUtilizado;
- [x] Editar a tela de Paciente para adequar às exclusões de EImagem e BHidrico;
- [x] Excluir Ctrl MVC de AtbEmUso, mas antes refatorá-lo em Ctrl MVC de Prontuario e ajustar sua Ctrl AngularJS;
- [x] Excluir Ctrl MVC de AtbJaUtilizado, mas antes refatorá-lo em Ctrl MVC de Prontuario e ajustar sua Ctrl AngularJS;


/*
- [ ] Implementar a parte de baixo da function;
swal({
  title: "Are you sure?",
  text: "You will not be able to recover this imaginary file!",
  type: "warning",
  showCancelButton: true,
  confirmButtonClass: "btn-danger",
  confirmButtonText: "Yes, delete it!",
  cancelButtonText: "No, cancel plx!",
  closeOnConfirm: false,
  closeOnCancel: false
},
function(isConfirm) {
  if (isConfirm) {
    swal("Deleted!", "Your imaginary file has been deleted.", "success");
  } else {
    swal("Cancelled", "Your imaginary file is safe :)", "error");
  }
});
 ------------------------------------------------------------------ //
*/

##Guia de Apresentação

```
> Imagem da Tela Inicial
```

## Modal que apresenta as seleções repetidas nos DropDrownList para interação:

```html
    <!--/ Modal -->
    <script type="text/ng-template" id="ModalRepetidas.html">
        <div class="modal-header">
            <h3 class="modal-title">Controle de Medicamentos para Interação</h3>
        </div>
        <div class="modal-body">

            <h3>Os seguintes items forma selecionados repetidamente:</h3>
            <br/>
            <div class="alert alert-warning">
                <ul>
                    <li ng-repeat="r in vRepetidos">
                        <h4>{{r}}</h4>
                    </li>
                </ul>
            </div>
            <div class="alert alert-info"><h4>Obs.: Já foram retirados da lista!</h4></div>
        </div>

        <div class="modal-footer">
            <button class="btn btn-primary" type="button" ng-click="ok()">OK</button>
        </div>
    </script>
    <!--/ Modal -->
```

## Em PrescricaoCtrl tem o código que chama o modal acima:

```javascript
    // ------------------------------------------------------------------------------------- //
    // -----/ Controle do Modal de Options repetidas em Interações ------------------------- //

    //$scope.mdctos = [];
    $scope.animationsEnabled = true;

    var openRepetidos = function (size) {

        var modalInstance = $uibModal.open({
            animation: $scope.animationsEnabled,
            templateUrl: 'ModalRepetidas.html',
            controller: 'ModalRepetidosCtrl',
            size: size,
            resolve: {
                vRepetidos: function () {
                    return $scope.repetidos;
                }
            }
        });

        modalInstance.result.then(function () {
        }, function () {
        });

    };
```

## Aqui o Controle em AngularJS que faz o meio campo entre o html e o código Angular:

```javascript
	app.controller('ModalRepetidosCtrl', function ($scope, $uibModalInstance, vRepetidos) {

		$scope.vRepetidos = vRepetidos;
		$scope.ok = function () {
			$uibModalInstance.close();
		};

	});
```


##Resolvido o problema de formato de data de "yyyy-MM-ddT00:00:00" para "dd/MM/yyyy".
###Depois de muitas pesquisas e queimar muita a "mufa", descobri que não precisava de função alguma, bastando chamar new Date(objeto data original);

```
Óbvio que neste caso estou recebendo uma coleção, pequisada por ID e não um JsonResult:
```

```javascript
    $scope.obterPorId = function (medico) {
        var medicoData = medicoService.GetMedicoPorId(medico.MedicoId);
        medicoData.then(function (medico) {
            $scope.medico = medico.data;
			//AQUI ESTÁ A SOLUÇÃO!
            $scope.medico.DataNascimento = new Date(medico.data.DataNascimento);

            $scope.Acao = "Atualizar";
            $scope.divmedico = true;
        }, function () {
            toastr["error"]("Erro ao obter medico!", "EvoluMed-Sys");
        });
    };
```


## Dicas Importantes:
###Para achar os métodos abaixo basta utilizar o namespace: Using Microsoft.AspNet.Identity; Tanto no controller quanto na view.

```csharp
/*DICA: 0001*/
User.Identity.GetUserId();
HttpContext.Current.User.Identity.GetUserId();
```


```

##Exemplo de Performance I:
### Retorno de Agendamento com Include("TabelaRelacionada): Pouco mais de 1kb;


```json
	{
	  "Medico": {
					"Especialidade": 
						{
							"EspecialidadeId": 1,
							"Descricao": "Cardiologia"
						},
					"MedicoId": 10,
					"Nome": "Claudio Henrique",
					"Crm": "45555877",
					"DataNascimento": "1971-10-15T00:00:00",
					"IdEspecialidade": 1
				},
	  "Paciente": 
				{
					"Convenio": {
									"ConvenioId": 2, 
									"Descricao": "ASSIM"
								},
					"EstadoDoPaciente": 
								{
									"EstadoDoPacienteId": 1, 
									"Descricao": "Estável"
								},
					"Leito": 	{
									"LeitoId": 7,
									"EspecificacaoDoLeito": 
									"Qto 300"
								},
					"Setor": 	{
									"SetorId": 7,
									"Sigla": "USI",
									"Descricao": "Unidade Semi-Intensiva"
								},
					"Sexo": 	{
									"SexoId": 1,
									"Descricao": "Feminino"
								},
					"PacienteId": 8,
					"NumAtendimento": "1234567807",
					"Peso": 84,
					"DataInternacao": "2016-12-08T00:00:00",
					"Cpf": "76464464412",
					"Rg": "800445-0",
					"RgOrgao": "DETRAN",
					"RgDataEmissao": "2016-12-08T00:00:00",
					"Email": "bsilvab@opt.com.br",
					"Nome": "Bárbara Silva",
					"Ativo": true,
					"DataNascimento": "2016-12-08T00:00:00",
					"idConvenio": 2,
					"IdLeito": 7,
					"Alergia": "Clozanepan, Atenalol",
					"idSexo": 1,
					"idEstadoDoPaciente": 1,
					"IdSetor": 7
				},
	  "AgendamentoId": 16,
	  "IdPaciente": 8,
	  "Data": "2017-04-10T03:00:00",
	  "Hora": "12:45",
	  "Exames": "Teste 2",
	  "Confirmado": true,
	  "IdMedico": 10
	}

```



##Exemplo de Performance II:
### Retorno de Paciente com Include("TabelaRelacionada): Apenas 1kb 927Bytes

```json
[
	{
		"Convenio":
			{
				"ConvenioId":3,
				"Descricao":"GOLDEN"
			},
		"EstadoDoPaciente":
			{
				"EstadoDoPacienteId":3,
				"Descricao":"Crítico"
			},
		"Leito":
			{
				"LeitoId":4,
				"EspecificacaoDoLeito":"Sala 202 C"
			},
		"Setor":
			{
				"SetorId":1,
				"Sigla":"CTI",
				"Descricao":"Centro de Tratamento Intensivo"
			},
		"Sexo":
			{
				"SexoId":1,
				"Descricao":"Feminino"
			},
		"PacienteId":2,
		"NumAtendimento":"1234567877",
		"Peso":75,
		"DataInternacao":"2014-11-23T00:00:00",
		"Cpf":"75535785768",
		"Rg":"07152955-6",
		"RgOrgao":"IFP",
		"RgDataEmissao":"1980-06-15T00:00:00",
		"Email":"elisamrrnn@bol.com.br",
		"Nome":"Elisa Mariana",
		"Ativo":true,
		"DataNascimento":"1960-05-02T00:00:00",
		"idConvenio":3,
		"IdLeito":4,
		"Alergia":"Losartana Potássica, Dipirona",
		"idSexo":1,
		"idEstadoDoPaciente":3,
		"IdSetor":1
	}
]	
```


