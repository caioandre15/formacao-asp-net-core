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
   - MVC
   - Razor Pages
   - Razor Library 
 - Services
   - Web API
   - SignalIR
 - SPA
   - Angular
   - React








