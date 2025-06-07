# Academia2025

Sistema de academia com ASP.NET Core e Entity Framework Core utilizando MySQL.

## 🔧 Requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)
- Visual Studio 2022 ou superior (recomendado)

## 📦 Pacotes NuGet necessários

Abra o Gerenciador de Pacotes do Visual Studio 

```bash
O Gerenciador de Pacotes do Visual Studio pode ser acessado através do menu 
"Ferramentas" > "Gerenciador de Pacotes NuGet" > "Console do Gerenciador de Pacotes".
```


Instale os seguintes pacotes:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Pomelo.EntityFrameworkCore.MySql
```

## 🔐 Arquivo .env

Crie um arquivo chamado .env na raiz do projeto com o seguinte conteúdo:

```
DB_HOST=localhost
DB_DATABASE= NOME_DO_BANCO
DB_USER=root
DB_PASSWORD=SENHA_DO_BANCO
```

## 🧬 Migrations

Criar migrations com 

```
dotnet ef migrations add "NOME_DA_MIGRATION"
```

Aplicar a migration no banco de dados

```
dotnet ef database update
```