# Portal do Aluno

Este projeto consiste em um painel Windows Forms simples, projetado para gerenciar informações de alunos. O objetivo principal é demonstrar duas abordagens distintas para interagir com um banco de dados PostgreSQL, utilizando Dapper e Entity Framework.

## Funcionalidades

* **Interface Gráfica:**
    * Painel Windows Forms com campos de texto para nome, idade e curso do aluno.
    * ListView para exibir os dados dos alunos armazenados no banco de dados.
* **Integração com PostgreSQL:**
    * Implementação de duas abordagens distintas para interagir com o banco de dados PostgreSQL.
        * **CR-Postgres-Dapper:** Utiliza a biblioteca Dapper para operações de criação e busca de alunos.
        * **CR-Postgres-EF:** Utiliza o Entity Framework para operações de criação e busca de alunos.

## Branches

Este repositório está organizado em duas branches principais, cada uma demonstrando uma abordagem diferente para interação com o banco de dados:

* **`CR-Postgres-Dapper`:**
    * Implementa a criação e busca de alunos utilizando a biblioteca Dapper.
    * Oferece uma abordagem mais leve e performática para acesso a dados.
* **`CR-Postgres-EF`:**
    * Implementa a criação e busca de alunos utilizando o Entity Framework.
    * Oferece uma abordagem mais abstrata e orientada a objetos para acesso a dados.

## Tecnologias Utilizadas

* C#
* Windows Forms
* PostgreSQL
* Dapper (branch `CR-Postgres-Dapper`)
* Entity Framework (branch `CR-Postgres-EF`)

## Como Executar

1.  Certifique-se de ter o PostgreSQL instalado e configurado.
2.  Clone este repositório.
3.  Navegue até a branch desejada (`CR-Postgres-Dapper` ou `CR-Postgres-EF`).
4.  Abra a solução no Visual Studio.
5.  Configure a string de conexão com o seu banco de dados PostgreSQL no arquivo de configuração correspondente (verifique os Readme das branches).
6.  Execute a aplicação.

## Contribuição

Fique à vontade para contribuir com este projeto! Você pode:

* Analisar o código e fornecer feedback.
* Abrir pull requests com melhorias ou novas funcionalidades.
* Relatar bugs ou problemas encontrados.

Estou sempre aberto a discussões e sugestões para aprimorar este projeto.
