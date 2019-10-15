# Live Coding - Semana .NET Core em C# - 14/10 à 18/10

<p align="center">
    <img src="https://i.postimg.cc/JhMc1Thw/net-core.png" />
</p>

Repositório responsável pelos códigos desenvolvidos durante o Live Coding no **[Twitch]()** e **[Youtube]()** a qual estaremos desenvolvendo alguns projetos em .NET Core 3.x

## Recursos Utilizados 🚀

* **[Download .NET Core 3.x](https://aka.ms/AA69ihe)** 
* **[Visual Studio Code](https://aka.ms/AA692ys)** 
* **[Extensão Vs Code - C# Microsoft](https://aka.ms/AA692zh)** 

## O que eu vou aprender?! 📘

Nesse tutorial você será capaz de desenvolver a sua primeira aplicação Web usando o .NET Core 3.x com Razor Pages. A aplicação consiste num CRUD (Create, Read, Update & Delete).

* **Classe: Filme**

- FilmeId
- Título
- Data de Lançamento
- Gênero
- Diretor
- Preço

## Vídeos da Live 🎥

* **[Dia 1](https://youtu.be/j4IJQdLxGuM)**
* **[Dia 2]()**
* **[Dia 3]()**
* **[Dia 4]()**
* **[Dia 5]()**

## Executando a Aplicação Localmente 🔥

Para executar localmente a aplicação você precisa entrar na pasta `src -> filmeslivecoding` e executar o seguinte comando:

```bash
> dotnet run
```

Após isso, você terá que abrir o browser na porta `http://localhost:5001`.

Para que, possamos executar o `Entity Framework` no projeto, se faz necessário executar os seguintes comandos dentro da pasta `src -> filmeslivecoding`

```bash
> dotnet tool install --global dotnet-ef
> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
> dotnet add package Microsoft.EntityFrameworkCore.Design
> dotnet add package Microsoft.EntityFrameworkCore.Sqlite
> dotnet restore
> dotnet ef migrations add InitialCreate
> dotnet ef database update
```

## Recursos Adicionais & Links Importantes  ⭐️

Durante a live, comento de alguns links e recursos importantes para aprofundar seus conhecimentos sobre .NET Core. São eles:

- ✅ **[Tutorial de .NET Core 3](https://aka.ms/AA69q93)**
- ✅ **[]()**
- ✅ **[]()**
- ✅ **[]()**
- ✅ **[]()**
- ✅ **[]()**
- ✅ **[]()**
- ✅ **[]()**

## Tenho Dúvidas... O que Faço?! ❓

Caso tenham dúvidas aos códigos desenvolvidos aqui, sintam-se a vontade em abrir uma **[ISSUE AQUI](https://github.com/glaucia86/live-dotnetcore/issues)**. Assim que possível, estarei respondendo as todas as dúvidas que tiverem!

**(documentação em desenvolvimento)**