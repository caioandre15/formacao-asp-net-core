# Formação ASP.NET Core

Formação ASP.NET Core do site desenvolvedor.io ministrado por Eduardo Pires.

No total são 4 cursos:

- Iniciando com ASP.NET Core  
- REST com ASP.NET Core com WebAPI
- Dominando o ASP.NET MVC Core    
- ASP.NET Core Enterprise Applications  

## Curso 01 - Iniciando com ASP.NET Core - Resumo

### Contexto histórico

ASP - Lançado em 1996 o ASP Clássico;  
ASP.NET WebForms - Lançado em 2002 junto com o .NET Framework; (Não existia o MVC)  
ASP.NET MVC - Alternativa ao WebForms lançado em 2009, chegou a versão 5 em 2013;  
ASP.NET Core - Anunciado em 2014 foi disponibilizado na versão 1.0 no final de 2016 e na versão 2.0 em 2017;  

### Por que um novo stack?

O principal motivo era o desempenho e que o antingo ASP.NET estava atrelado ao Windows que por sua vez impactava na escalabilidade e manutenção da tecnologia.

### Novidades no ASP.NET Core

3 Pilares importantes: Inovação, Open Source e Multiplataforma.

1 - Inovação: Acompanhamento dos testes de performance dos ASP.NET Core [Link](https://github.com/aspnet/benchmarks)  
2 - Open Source: .NET foundation (instituição que trabalha para deixar o .NET cada vez mais Open Source) [Link](https://dotnetfoundation.org/)  
3 - Multiplataforma (Windows, Linux...)  

### .NET Core

.NET Core é multiplataforma, compatível com aplicações em nuvem, containers e vem para substituir o .NET Framework padrão.

### .NET CLI

Suporte a linha de comando que pode ser realizado a partir do seu terminal. Importante ferrramenta para não ficar apenas dependente do VS.

### .NET Standard Library

O .NET Standard é uma especificação de API que define, dada uma versão, quais Bibliotecas de Classe (Base Class Libraries) devem ser implementadas.

### IDE's utilizadas

- Visual Studio Code (Multiplataforma, Open Source, Free)  
   Simples, leve e um pouco limitado em relação ao VS.
- Visual Studio (Windows, Free(Community), Professional, Enterprise)  
   Pesado e robusto com muitas funcionalidades que trazem agilidade no desenvolvimento por estarem reunidas todas em um só lugar. 
   
### Ambiente

Instalação do .NET, é indicado utilizar as versões LTS, que possuem suporte por vários anos.

Comandos direto no CMD:  
````
dotnet --info  
dotnet -h  
````
Gerenciamento de versões

Não é um problema ter várias versões do .NET Core instaladas em sua máquina, desde que a versão utilizada no projeto esteja configurada no arquivo global.json 

````
{
  "projects": ["src", "tests"],
  "sdk": {
    "version": "2.1.402"
  }
}
````

### Minha primeira APP ASP.NET Core

O ASP.NET Core é uma tecnologia para web e fornece alguns tipo de templates, que tipos de formatos específicos de projetos web.

Tipos de projetos:

ASP.NET Core:
 - RAZOR (sites)
   - MVC (Sustituto do web forms e aplica o padrão MVC)
   - Razor Pages (Não aplica o padrão MVC, posui apenas uma página Razor, simples)
   - Razor Library (Atende o MVC e o Razor Pages, permite a criação de uma pagina reutilizavel em vários projetos)
 - Services
   - Web API (Padão MVC, sem a parte do Razor, implementa o padrão REST)
   - SignalR (Específico para comunicação em tempo real, Chat, notificações...)
 - SPA (Single Page Application serve de Template com integrações com os principais Frameworks)
   - Angular
   - React
   - Blazor (Framework da microsoft)
 - IDENTITY (Gerenciamento de usuários)

Minha primeira App VS:

Caminho para criar um novo projeto:
File>New Project>ASP.NET Core Web App>Local Pasta>Criar Projeto.

Conhecendo a estrutura de um projeto:  

- Arquivo .csproj      
Editando o arquivo .csproj podemos verificar que é nele que fica localizado a versão utilizada do ASP.NET Core, configurações da utilização do docker e de autenticação e etc. Definição do aquivo .csproj "C# (C Sharp) projeto de programação criado com o Microsoft Visual Studio; contém configurações de projeto e referências aos arquivos usados pelo projeto; salvo no formato MSBuild, que pode ser compilado em um programa executável usando a plataforma MSBuild."

- Connect Services  
Importante ferramenta para adicionar serviços externos ao seu projeto. Ex: Monitoramento com o Application Insights do Azure. 
Definição do site da [documentação da microsoft](https://docs.microsoft.com/en-us/visualstudio/azure/overview-connected-services?view=vs-2022)
"Os Serviços Conectados são uma coleção de ferramentas no Visual Studio que ajudam você a conectar seu aplicativo ao seguinte: Serviços do Azure. Pontos de extremidade OpenAPI. Pontos de extremidade gRPC (Remote Procedure Call). Pontos de extremidade do Windows Communication Foundation (WCF)."

- Dependencies  
  - Analyzers (Para gestão de Performance e monitoramento do VS)
  - Nuget (Pacotes instalados - Todas as features do ASP.NET Core estão nestes pacotes)
  - Framework (Framework utilizado)
  - SDK (SDK utilizado)
 
- Properties  
Dentro desta pasta está localizado o arquivo lauchSettings.json. O principal objetivo deste aquivo é configurar como a aplicação será iniciada dentro do VS.
Entre as configurações de applicationUrl, sslPort e etc, temos três tipos de ambientes "ASPNETCORE_ENVIRONMENT" que são: Development, Staging e Production, em cada ambiente o VS irá se comportar de uma forma diferente.  
A execução do IIS armazena as configurações em "iisSettings" extendendo para as profiles que podem ser criados. Existe também a execução selfhosting "auto hospedando a aplicação" no comando Project, neste caso é necessário passar a url.
[Link](https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/environments?view=aspnetcore-6.0) da documentação para entender mais sobre configuração de variaveis de ambiente.

- wwwroot
Possuí uma função especifica, armazenar os arquivos státicos do projeto. Arquivos CSS, JS, icones, fontes e bibliotecas em geral. 
Arquivos státicos, são arquivos que não são compilados. São de texto puro ou em binários no caso de imagens.

- Controllers, Views e Models serão abordados no curso 02.

- appsettings
São aquivos de configuração de ambiente, onde podem conter tokens, connections strings e etc.

- Program.cs
Possui a função de dizer como o sua aplicação irá funcionar. Conforme configurado o comando Program para rodar a aplicação como selfhosting este comando nada mais é do que uma chamada para a classe Program que irá criar um host para que seja executada aplicação. Realizando a criação do host, compilação e execução a partir das configurações localizadas na classe startup.cs.

- Startup.cs
Configuração de serviços e dependências.

Criando minha primeira App no VS Code:
- Abrir um prompt de comando.
- Navegar para pasta
- Comandos:
````
dotnet -h (Ajuda)
dotnet new -h (Ajuda para o comando new)
dotnet new -l (Listar Templates)
dotnet new mvc -n [Nome do Projeto] (Criando um projeto mvc)
code . (Para abrir o VSCode no repositório atual)
dotnet run --launch-profile Prod (Para rodar com o perfil de PRD)
dotnet watch run (Para que houver alteração no projeto a aplicação se "auto carregar")
dotnet add package automapper (Para instalar um pacote)
dotnet list package (Para listar as depndências instaladas)
````

### ASP.NET Core por baixo dos panos
Pipeline do ASP.NET Core (Importante entender)
OWIN - Open Web Interface for .NET - É uma especificação de como separar o servidor da aplicação.

No passado no Modelo ASP.NET MVC 5 ou anterior, havia o WEB HOST(IIS) dentro dele rodavam as aplicações ASP.NET.
Para o Modelo do ASP.NET Core a ideia é a separação do WEB HOST(IIS) das aplicações ASP.NET.
Agora além do próprio (IIS) temos:
CustomHost: Possibilidade de criar seu próprio host.
SelfHost: Possibilidade de hospedar o ASP.NET no seu próprio processo.

WEB HOST(IIS) - OWIN - ASP.NET

O que é um Middlewares:

Middlewares são componentes de software em uma aplicação ASP.NET Core. Estes componentes manipulam dados entre
os requestes e responses.

Um middleware possui uma responsabilidade única e pode trabalhar lado a lado com outros middlewares. Quando falamos
do pipeline do ASP.NET Core estamos falando basicamente de Middlewares.

Imagine um middleware como um processo em que você teria ação sendo disparada por uma request pelo usuário solicitando alguma coisa ao servidor, passa por este processo e gera um response, se este response for o final ele retorna ao user/cliente. Caso haja mais middleware no meio do caminho ele encaminha o request para o próximo middleware.

Olhando por outro aspecto um middlware seria uma espécie de barramento, onde passa por um fluxo de processo e esses fluxos são encadeados. Então, entra um request que executa um middlware que ao terminar a execução chama o comando next(), este comando verifica se existe um próximo middlare, caso exista executa a sua lócgica. E assim, sucessivamento até chegar no último middlware. Depois existe o processamento na volta, porque um coisa é o tratamento da request e outra é o tratamento do response. Então existe tratamento na ida e na volta.

Interfaces que compoem o ASP.NET Core:

IConfiguration:
Representa a raiz de uma hierarquia Microsoft.Extensions.Configuration.IConfiguration
Responsável por gerenciar as constraints do ASP.NET Core, obtem as informações pela chaves no arquivo appsettings, um exemplo seria uma connection string.

IServiceCollection:
Representa um contrato para uma coleção de serviços. 
Essa interface é estendida por classes que implementam middlewares através do recurso de injenção de dependência.
Então, o IServiceCollection serve para expor um contrato com uma coleção de serviços e são utilizados estes serviços para adicionar os 
middlewares dentro do ConfigureServices da sua classe Startup.cs.

IApplicationBuilder
Representa um contraro para classes que irão prover mecanismos de configuração de um Middleware. Essa interface
é estendida por classes que implementam métodos de configuração para cada Middleware. Utilizada para configurar os middlewares da sua aplicação.

IHosting Environment
Fornece informações sobre o ambiente de hospedagem Web em que uma aplicação está sendo executada.

Classe Startup.cs e Middlewares

Entendimento da classe Starup que não existe mais a partir do .Net 6.0 e criação de um middleware.

A ordem que os middlewares são chamados é importante, inclusive se for adicionado o middleware Identity é necessário chama-lo antes do MVC.

### Recapitulando Curso 01:
Entendemos que o ASP.NET Core é um framework aberto e customizável, saímos de um bloco monolítico (System.WEb) para uma plataforma aberta e flexível.
O novo pipeline do ASP.NET Core é uma coleção de Middlewares trabalhando em conjunto no estilo "pay as you go" que significa que usaremos somente aquilo que
for necessário e nada mais. 

## Curso 02 - REST com ASP.NET Core com WebAPI - Resumo  

### Rest  

Protocolo Http:  

Modelo Cliente servidor.  

Para realizar uma request é necessário seguir um padrão de preenchimento, por exemplo:  
- Verbo Http (Get, Post, Put, Delete)  
- URI (Endpoint)  
- Versão do protocolo http  
- Request Header (Browser versão, autenticação)  
- Request Message (Informação para realizar a ação dados para cadastro, por exemplo)  

Para Response:  
- Response Code (200, 500, 404...)  
- Versão Http  
- Response Header (Cookie, token)  
- Response Message (Informação solicitada)  

REST vs. SOAP:  

REST - Representational State Transfer - um padrão apenas de texto que o torna bastante leve. Utiliza geralmente JSON.
SOAP - Além dos dados no pacote Http é enviado o padrão SOAP que o deixa mais pesado. Utiliza o padrão XML.

Arquitetura Rest:  
Nada mais é do que criar um nível de abstração ente as API's.
Programação distribuída o todo funcionando em pedaços.
Uma vez que temos n API's podendo serrm escritas em diferentes linguagens mas respeitando os o modelo REST é possível que todas trabalhem
em conjunto em um mesmo sitema diistribuido, pois cada uma entrega sua funcionalidade seguindo o mesmo padrão.

Arquitetura REST em Microservices:  
Nada mais é do que uma Arquitetura REST, só que cada API tem uma funcionalidade bem definida e compacta.

### Criando uma aplicação Web API:

Criação do Projeto no VS Code:  

Lstagem de templates:
````
dotnet new --list
````
Nome do template utilizado é o "webapi"
````
dotnet new webapi -h
````
Criação do projeto:
````
dotnet new webapi -n [Nome da API]
cd [Path do diretório da API]
code . (Abre o VS Code direto na pasta criada para o projeto)
````

Criação do Projeto no VS:

Na primeira tela clicar em "Create a new project";
Pesquisar por API na barra de busca;
Selecionar ASP.NET Core Web API;
Selecionar a versão do framework;
Authentication, selecionar none;
Deixar marcado o check HTTPS e desmarcado para Docker;
Deixar marcardo Use Controllers e Enable OpenAPI support;

Explicações:
Authentication Type - None, pois iremos adicionar manualmente.
Configure for HTTPS - Para gerar com suporte a SSL.
Enable Docker - Não precisaremos neste momento.
Use Controllers - Não utilizaremos Minimal API (conheça mais sobre minimal API's [neste vídeo](https://www.youtube.com/watch?v=aXayqUfSNvw)).
Enable OpenAPI support - Para ativar suporte ao Swagger (documentação REST).

Mudanças na WebAPI no ASP.NET 6:

Por uma questão de compatibilização com o padrão de código escrito em C# até o momento é recomendável desativar o suporte a validação de Nullable Types do CSPROJ (clique 2x no projeto para abrir);

É importante remover esta chave em todos os projetos que forem criados caso não queira tratar cada propriedade do seu código como Nullable;

````
<Nullable>enable</Nullable>
````

A maior mudança é a saída da classe Startup.cs da estrutura do projerto, toda sua responsabilidade foi levada para a classe Program.cs.
Explicações:
````
// O builder é responsável por fornecer os métodos de controle
// dos serviços e demais funcionalidades na configuração da App
var builder = WebApplication.CreateBuilder(args);

// Daqui para baixo é conteúdo que vinha dentro do método  ConfigureServices() na antiga Startup.cs
// Nesta area adicionamos serviços ao pipeline

// Essa é a nova forma atual de adicionar suporte a API
builder.Services.AddControllers();

// Adicionando suporte de geradores de metadados (para documentação)
builder.Services.AddEndpointsApiExplorer();

// Adicionando suporte a documentação OpenAPI
builder.Services.AddSwaggerGen();

// Essa linha precisa sempre ficar por último na configuração dos serviços
var app = builder.Build();

// Daqui para baixo é conteúdo que vinha dentro do método Configure() na antiga Startup.cs
// Aqui se configura comportamentos do request dentro do pipeline
if (app.Environment.IsDevelopment())
{
    // Chamando o uso do Swagger quando for modo desenvolvimento
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Força o redirecionamento HTTPS
app.UseHttpsRedirection();

// Implementa o uso de validação de autorização
app.UseAuthorization();

// Mapeia todas as controllers para criar uma coleção de rotas
app.MapControllers();

// Essa linha precisa sempre ficar por último na configuração do request pipeline
app.Run();
````
Mudanças na controller:
````
using Microsoft.AspNetCore.Mvc;

namespace MinhaAPI.Controllers
{
    // Para uma controller responder como API precisa ter esse atributo
    [ApiController]
    
    // Rota - No caso de uso de [controller] a rota será o nome da controller ex:
    // https://localhost:5001/WeatherForecast
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase // <<< Repare na Herança da controller base, é uma classe controller mais simples do que a do MVC    
    {
        private static readonly string[] Summaries = new[]
        {
          "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        // Declaração do Logger do ASPNET
        private readonly ILogger<WeatherForecastController> _logger;
        
        // DI do logger 
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // Action (verbo GET)
        // Irá retornar uma coleção (fake) de previsão do tempo
        // GET - https://localhost:5001/WeatherForecast/
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
````
O arquivo launchSettings.json já vem preparado para HTTP e HTTPS assim como rodar o projeto via IISExpress ou Kestrel:
````
{
  "$schema": "https://json.schemastore.org/launchsettings.json",
  "iisSettings": {                                  // Configuracoes do IIS (apenas VS 2022)
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:48782",
      "sslPort": 44373
    }
  },
  "profiles": { 
    "MinhaAPI": {                                   // Perfil para rodar via Kestrel
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "launchUrl": "swagger",
      "applicationUrl": "https://localhost:7222;http://localhost:5222",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "IIS Express": {                                 // Perfil para rodar via IISExpress
      "commandName": "IISExpress",
      "launchBrowser": true,
      "launchUrl": "swagger",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
````

## Controllers

Herda da ControllerBase que é mais leve do que a Controller utilizada o MVC.
Mas apenas a ControllerBase não é suficiente, é necessário a Implementação da ApiController também.

Rotas:

````
Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {}
````

Acima é importante destacar que a rota recebe o atributo [controller] que por sua vez recebe o nome da controler. No exemplo acima "values", pois o nome
do método corresponde a ValuesController ou seja o valor vem do que está antes de Controller no método Values/Controler.

O verbos podem especid=ficar um template de rota ex:
````
[HtttpGet("{id}")]
````

Neste caso não sendo necessário declarar o atributo Rote, este atributo fica mais sendo mais utilizado na controller para o prefixo.

É importante especificar o tipo de dado que está recebendo no Get ex:
````
[HtttpGet("{id}:int")]
````

Action Results e Formatadores de Respostas

Action Result é o resultado para uma ação. Em um método de uma API em que o retorno é um Action Result é possível retornar um bad request ou um status code 200 por exemplo, agora se não utilizarmos e retornarmos um tipo de variavel, por exemplo não consiguiremos retornar esses status codes.

Ex. de Action Results:
````
public ActionResult<IEnumerable<string>> Get()
{
 return Ok()
}
````
Modificadores do método:

[FromBody] especifica que a informação estará sendo buscada no body da requisição.
Obs: [FromBody] Não é necessário especificar se o tipo do dado que irá receber a informação dor complexo. Ex. Produto.
[FromRoute] especifica que o valor está vindo da url da requisição. Não sendo mais utilizado, uma vez que na rota já está especificado que a rota recebe um valor 
e possuí a mesmo nome da variável na rota e no parâmetro.
````
[HttpPut("{id}")]
public void Put([FromRoute] int id, [FromBody] string value) // Com [FromRoute]
public void Put(int id, [FromBody] string value) // Sem [FromRoute]
````
[FromForm] especifica que a informação está vindo de um formulário. Content-Type Form-Data.  
[FromQuery] especifica que a informação virá dos Query Parameters.  
[FromService] especifica interface ou uma classe que irá fazer uma resolução via injeção de dependência.  

Importante preencher os tipos de retornos que a API possui para efeito de documentação.  
[ProducesResponseType(typeof(Product), StatusCodes.Status201Created)]  
[ProducesResponseType(StatusCodes.Status400BadRequest)]  

Metódos reult aprendidos:  
````
BadRequest() // Retorna erro status code 500.  
Ok() // Retorna Sucesso status code 200.  
CreatedAtAction("Post", product) // Retorna sucesso de criação status code 201  
NotFound() // Página não encontrada status code 404
NoContent() // Sucesso 204
````
Formatadores de dados de resposta personalizados:

Para realizar o retorno (ex. de sucesso ou de erro) podemos criar uma classe abstrata que herde da ControllerBase e customize os retornos realizando uma validação antes de envia-lo. É necessário alterar a herança da classe ControllerBase da Controller para a MainController criada para aplicar a customização.

````
[ApiController]
    public abstract class MainController : ControllerBase
    {
        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(new
                {
                    sucess = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                sucess = false,
                errors = ObterErros()
            });
        }

        public bool OperacaoValida()
        {
            //Minhas validações
            return true;
        }

        public string ObterErros()
        {
            return "";
        }
    }
````

Analisadores e Convenções:

Para utilizar o analisador precisamos instalar o pacote abaixo em Package Manager Console execute o comando abaixo.
O analisador é importante para analisar os results enviados e adicionar os ProducesResponsesType que estiverem faltando, por exemplo. Isso será interassante
para a documentação da API.

````
Install-Package Microsoft.AspNetCore.Mvc.Api.Analyzers
````

Para utilizar as convenções basta adicionar a linha abaixo de acordo com o verbo http adequado. Utilizando as convenções não é necessário adicionar os ProducesResponsesType.

````
[ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
````

Também pode ser inserido de forma mais genérica na classe Product.cs ou na antiga Startup.cs.

````
[assembly: ApiConventionMethod(typeof(DefaultApiConventions))]
````

### Criando minha primeira API REST:

Processo rápido - CRUD:

Primeiro foram adicionados os Nugets Packs. (EntityFrameworkCore, EntityFrameworkCore.Relative e EntityFrameworkCore.SqlServer)  
Adicionada a model Fornecedor mapeando os campos com tamanho e mensagens de erro;  
Adicionada a classe ApiDbContex, para realizar a conexão com o banco;  
Adicionado DbContext na classe Startup.cs;    
Adicionado a conection string no arquivo appsettings;  
Gerada as migrations e depois criado o banco de dados e suas tabelas;  
Criado uma nova controller através do scaffold;  


Adicionando ApiDbContext na classe Startup.cs
````
services.AddDbContext<ApiDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
````

Adicionando ConnectionString no arquivo appsettings:
````
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MinhaApiCore;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
````
Comandos Executados no Packege Manager Console:
````
Add-Migration Initial // Cria Migrations
update-database // Cria o banco e as tabelas
````

Entendimento da controller criada:

- Foi injetado um DbContext através de um construtor;  
- Métodos asincronos precisam retornar uma Task<>;  
- Foi criado um CRUD atraves do Scaffold;  

Setup API Completa

- Criar uma solution em branco (Selecionar Other em projects);  
- Criando pastas de estrutura do projeto (src, sql, tests);  
- Na pasta src ficará toda a parte de negócio e deverá ser adicionado os projetos Business e Data;  
- Criar um novo projeto ASP.NET Core Web Application;  
- Adicionar em dependências da API a referência aos projetos Business e Data;  
- Definir a API como Startup Project;  

Implementando DTO's:

O projeto está dividido em camadas, a camada de negócio possuí models que não podem ficar expostas. Para isso não ocorrer são criados 
os DTO's ou View Models para ficarem expostas respeitando as regras de negócios da aplicação.

Setup - Controllers e Startup

Criando MainController:

Uma classe abstrata que servirá como base das controllers e também para validaçãoes de erro, modelstate e operação de negócios.

Crinado FonecedoresController:

Uma classe que herda da classe MainController. 
Devemos adicionar a rota.
Não é necessário implementar um action result para listar todos os fornecedores, porque ao retornar um resultado já é retornado o status
code 200.
Precisamos injetar a dependência da classe Repository.
Precisamos converter as models do banco de dados para os DTO's. Para isso utilizamos a ferramenta AutoMapper.

Comando para instalar o AutoMapper
````
install-package AutoMapper.Extensions.Microsoft.DependencyInjection -Version 6.1
````

Adicionar o serviço do Automapper na classe Startup:
````
services.AddAutoMapper(typeof(Startup));
````

Criar uma pasta chamada Configutaion e adicionar uma classe chamada AutomapperConfig. Esta classe deve herdar de Profile e servirá para fazer o de para entre os 
DTO's e as models do banco de dados.

Devemos injetar o IMapper na controller e realizar utilizar o comando Map<> para mapear o retorno correto.
Devemos adicionar o contexto na classe Startup e adicionar a ConnectionString no arquivo appsettings.

Criar o banco:
````
update-database -verbose
````

Modelando a controller de Fornecedores:  

Criado o método ObterPorId:  
- Foi criado um método auxiliar ObterFornecedorProdutosEndereco para consultar o repositório;  
- Depois é validado o retorno.  

Criado o método Adicionar:  
- Foi verificado a validação ModelState.Isvalid.  
- Foi injeto o serviço de forncedor que aplica as validações da camada de negócio.  
- É validado o retorno.

Criado o método Atualizar:  
- Adicionar validação se o id da rota é igual ao id passado no body.
- Depois seguir com o mesmo padrão do método adicionar, apenas alterando o método para atualizar.

Criado o método Remover:  
- Foi criado um método auxiliar ObterFornecedorEndereco para consultar o repositório.  
- Caso o fornecedor não seja encontrado é retornado BadRequest.  
- É invocado o serviço de forncedor com o método de Remover.  
- É validado o retorno.  

Criado a consulta de endereço:
- É necessário criar uma nova rota, quando temos mais de um Get por id.

Atualizar endereço:
- Injeção de depêndencia IEnderecoRepository.

Foi adicionado na Controller Fornecedor:
````
INotificador notificador) : base(notificador)
````

Cadastro de Produtos e upload de Imagem:

- Criado uma nova controller ProdutoController;
- Inserindo a imagem do produto em base 64:

Consumindo API via Angular 7

Foi adicionado o projeto de FE desenvolvido em angular ao projeto e realizado o entendimento do funcionamento do fluxo de cadastro de produtos.

Comandos:
````
ng s  -> Para compilar e executar o projeto FE.
````

Upload de arquivos grandes:
Alterar o tipo String para IFormfile. A diferença é deste tipo é que faz o streaming deste dado reduzindo o impacto de um envio de uma imagem grande.
São realizados várias técnicas para que isso ocorra, mas basicamente é entender como enviar a imagem via Query Params junto ao objeto serializado "produto".

### Segurança

Autenticação de uma API:
Adicionar o atributo [Authorize] restringir o acesso para sua API. Para restringir todos os métodos, pode ser colocado apenas na Controller.
Adicionar o atributo [AllowAnonymous] permite usuários anonimos. Pode ser adicionado para liberar apenas um método da controller.

Implementando o ASP.NET Identity:
Criar a classe IdentityConfig.cs dentro da pasta Configuration.
Criar uma pasta Data para adicionar um novo contexto para o identity.
Adicionar o contexto:
````
services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
````

Criar as Migrations:

````
add-migration Identity -Context ApplicationDbContext
````

Criar as tabelas:

````
update-database -Context ApplicationDbContext
````

Adicionar o Identity ao projeto:
````
services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
````

Adicionar na classe StartUp:

````
app.UseAuthentication();
````

Criar uma controller de autenticação:

- Utilizar a injeção de depêndencia das classes SignInManage e UserManager;

Adicionar Mensagens em Português para os retornos do identity.
- Criar uma classe chamada IdentityMensagensPortugues e m Extensions.
- Adicionar as mensagens na classe.
- Adicionar a refereência em identity config em Configuration.

JWT - JSON WEB TOKEN

Fluxo:
- Cliente envia usuário e senha.
- API retorna token.
- Cliente armazena o token e utiliza para acessar toda a aplicação.

JWT.
Vermelho - Headers Criptográfia e tipo do Token.
Rosa - Dados
Azul - Assinatura com a chave secreta

Autorização baseada em Claims via JWT.

Criar classe CustomAuthorize em Extensions.
Refatorar classe AuthController para que seja adicionado as claims no token.
Adicionar o LoginresponseViewModel para que seja retornado não apenas o token, mas as claims e dados referentes a criação do token.

Interagindo com usuário logado em qualquer camada:

- Criar uma iterface chamada IUser na camada de negócio;  
- Criar uma classe na camada da API na pasta Extension para implementar a interface criada;  
- Resolver a dependência em DependencyInjectionConfig e reolver as classes adicionadas;  
- Adicionar implementação na classe MainController;  
- Adicionar IUser nos construtores da Controllers que herdem da MainController;    

CORS - Cross-Origin Resource Sharing (Compartilhamento de recursos com origens diferentes) é um mecanismo que usa cabeçalhos adicionais HTTP para informar a um navegador que permita que um aplicativo Web seja executado em uma origem (domínio) com permissão para acessar recursos selecionados de um servidor em uma origem distinta. Um aplicativo Web executa uma requisição cross-origin HTTP ao solicitar um recurso que tenha uma origem diferente (domínio, protocolo e porta) da sua própria origem.

[https://developer.mozilla.org/pt-BR/docs/Web/HTTP/CORS](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/CORS)

Cors é um relaxamento para receber requisições de outras origens em uma aplicação.

[DisableCors] - Apenas para desabilitar o cors em uma controller.

[EnableCors("Development")] - Só funciona se não tiver uma politica global configurada.

### Versionamento e Documentação da API

Versionamento:  

Para versionar precisamos instalar dois pacotes.  
Em Package Manager Console digite os comandos para instalar.

````
Install-Package Microsoft.AspNetCore.Mvc.Versioning -Version 3.1.2
Install-Package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer -Version 3.2.0
````

Adicionar as configurações em ApiConfig. e adicionar o versionamento na rota das controllers.  

Documentação a API com Swager:  

Para documentar precisamos instalar o pacote abaixo:  

````
Install-Package Swashbuckle.AspnetCore -Version 4.0.1
````
Adicionar configuração padrão na classe startup.


### Logging e Monitoramento
















