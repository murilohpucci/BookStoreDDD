# BookStoreDDD

## Objetivo
Apresentar um CRUD de livros utilizando os conceitos de Domain Driven Design(DDD), AutoMapper, Injeção de Dependências(DI), IoC (Inversion of Control), MVC 5 e Entity Framework.

## Ambiente de Desenvolvimento

 As ferramentas e tecnologias aqui descritas foram usadas durante o desenvolvimento do projeto. Por favor sinta-se a vontade para utilizar outras versões e ajudar nesta documentação

 * SQL Server Express 2017
 * IDE: Visual Studio Community 2017
 * .NET Framework 4.6 ou superior

## Configuração

 1. Após clonado o projeto, abra a solução que se encontra na raiz do projeto no Visual Studio;

 2. Com o projeto aberto, abra a pasta "ProjetoModeloDDD.Presentation";
 
 3. Ao abrir a pasta, aperte com o botão direito em cima do projeto e escolha a opção para este ser o projeto de início;
 
 4. Feito isso configure a sua string de conexão na linha 18 do arquivo web.config(este arquivo está dentro da "ProjetoModeloDDD.Presentation"), colocando qual o ip do seu servidor de banco de dados, usuário e senha;
 
 ```
<add name="ProjetoModeloDDD" providerName="System.Data.SqlClient" connectionString="Data Source=localhost;Initial Catalog=BookStore;Integrated Security=False;User Id=sa;Password=1234;MultipleActiveResultSets=True" />
 ```
 
 5. Abra o seu gerenciador de pacotes do nugget e escolha o projeto "ProjetoModeloDDD.Infra.Data";
 
 6. Execute o comando:
    >Enable-Migrations
 
 7. Depois execute o comando:
    >Database-Update
 
 8. Feito isso o seu banco local de desenvolvimento está mapeado e criado, basta executar o projeto para que as devidas referências e bibliotecas sejam compiladas;

 ## ChangeLog
 
 Acesse o changelog para saber tudo o que está acontencendo no projeto: CHANGELOG.md