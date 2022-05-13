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

- Connectes Services  
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

REST vc SOAP:  

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

Criação do Proketo no VS Code:  

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

Criação do Proketo no VS:

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




































