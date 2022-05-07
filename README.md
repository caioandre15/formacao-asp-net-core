# Formação ASP.NET Core

Formação ASP.NET Core do site desenvolvedor.io ministrado por Eduardo Pires.

No total são 4 cursos:

- Iniciando com ASP.NET Core  
- Dominando o ASP.NET MVC Core  
- REST com ASP.NET Core com WebAPI  
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
dotnet add package automapper (Para instalar um pacote)
dotnet list package (Para listar as depndências instaladas)
````

### ASP.NET Core por baixo dos panos
Pipeline do ASP.NET Core (Importante entender)
OWIN - Open Web Interface for .NET - É uma especificamção de como separar o servidor da aplicação.

No passado no Modelo ASP.NET MVC 5 ou anterior, havia o WEB HOST(IIS) dentro dele rodavam as aplicações ASP.NET.
Para o Modelo do ASP.NET Core a ideia é a separação do WEB HOST(IIS) das aplicações ASP.NET.
Agora além do próprio (IIS) temos:
CustomHost: Possibilidade de criar seu próprio host.
SelfHost: Possibilidade de hospedar o ASP.NET no seu próprio processo.

WEB HOST(IIS) - OWIN - ASP.NET

Middlewares:





























