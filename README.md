# API gerenciador de pedidos

API desenvolvida em C# de um gerenciador de pedidos

<p>
API desenvolvida para gerenciar clientes, produtos e pedidos, permitindo operações CRUD sobre cada uma das entidades do sistema. Esta aplicação foi criada utilizando C#, Entity Framework e SQL Server.
</p>

<p align="center">
    <a href="#-projeto">Projeto</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
    <a href="#-executar">Executar</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
    <a href="#-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
    <a href="#-melhorias">Melhorias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
    <a href="#-licença">Licença</a>
</p>

<p align="center">
    <img alt="License" src="https://img.shields.io/static/v1?label=license&message=MIT&color=49AA26&labelColor=000000">
</p>

<br>

## 💻 Projeto

O objetivo deste projeto é fornecer uma solução funcional para gerenciar clientes, produtos e pedidos, incluindo funcionalidades como:

- Cadastro de clientes com informações detalhadas;
- Registro de produtos com seus tipos e valores;
- Criação e atualização de pedidos com status e detalhes sobre os produtos incluídos;
- A API utiliza o padrão RESTful para organizar e expor endpoints que realizam as operações necessárias para cada entidade do sistema.

## ⏳ Executar

Requisitos:
- .NET 6 ou superior instalado no ambiente local;
- SQL Server configurado;
- Ferramenta para testar a API (como Swagger ou Postman);

Passos para executar:
1. Clone o repositório: `git clone https://github.com/seu-usuario/seu-repositorio.git`
2. Configure o banco de dados:
    - Atualize o arquivo `appsettings.json` com a string de conexão do seu SQL Server;
    - Execute as migrações do Entity Framework para criar o banco de dados: `dotnet ef database update`
3. Inicie a aplicação:
    - Rode o projeto utilizando o comando: `dotnet run`
4. Acesse o Swagger:
    - Após iniciar o projeto, acesse a URL padrão para a documentação Swagger: `http://localhost:5000/swagger`
5. Teste os endpoints:
    - Utilize o Swagger ou o Postman para realizar as operações CRUD sobre clientes, pedidos e produtos.

## 🚀 Tecnologias

Esse projeto foi desenvolvido com as seguintes tecnologias e ferramentas:

- C#: Linguagem principal da aplicação;
- .NET: Framework para construção da API;
- Entity Framework Core: ORM para interação com o banco de dados.
- SQL Server: Banco de dados relacional utilizado.
- Swagger: Documentação e interface para testes da API.

## 💡 Melhorias

Para futuras melhorias tenho os seguintes pontos:

- Implementar autenticação e autorização nos endpoints.
- Adicionar suporte a paginação e filtros nas listagens.
- Implementar notificações em tempo real (via SignalR) para novos pedidos.
- Criar testes automatizados para garantir a qualidade do código.

## 📝 Licença

Este projeto está sob a licença MIT. Para mais detalhes, consulte o arquivo LICENSE.