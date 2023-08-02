# ERP Governador Store

## Descrição do Projeto:
O ERP Governador Store é um Sistema de Gestão Empresarial (ERP) completo e poderoso, desenvolvido utilizando a plataforma .NET 7 com Razor Pages e Entity Framework.
Ele foi projetado para atender às necessidades de empresas de todos os tamanhos e segmentos.
O sistema fornece uma solução centralizada para gerenciar as operações diárias, incluindo controle de estoque, faturamento, finanças, recursos humanos e muito mais.
Além disso, possui integração com a API dos correios para busca de CEPs, o que facilita a gestão logística. 🚀

## Funcionalidades Principais:
- Controle de Estoque: Gerenciamento abrangente do estoque, controle de inventário, alertas de estoque baixo e reabastecimento automatizado. 📦
  
*O ERP Governador Store é projetado com uma estrutura modular, e módulos adicionais como Vendas, Finanças e outros estão planejados para desenvolvimento futuro.* 🔮

## Tecnologias Utilizadas:
- .NET 7: Plataforma de desenvolvimento utilizada para criar o sistema ERP Governador Store.
- Entity Framework: Framework ORM (Object-Relational Mapping) que facilita o acesso e manipulação de dados no banco de dados.
- Razor Pages: Abordagem de programação web baseada em páginas que facilita o desenvolvimento de interfaces de usuário.
- Angular: Framework JavaScript para construção de interfaces de usuário, utilizado para criar a interface do ERP.
- SQL Server: Sistema de gerenciamento de banco de dados utilizado para armazenar os dados do ERP.
- Integração com API dos Correios: Utilizada para obter informações de CEPs e facilitar a gestão logística.

## Instalação e Configuração:
Para executar o ERP Governador Store em sua máquina local, siga os passos abaixo:
1. Faça um clone deste repositório para o seu ambiente de desenvolvimento: `git clone https://github.com/alexandrefgs/ERPGovernadorStore`
2. Navegue até o diretório do projeto: `cd erp-governador-store`
3. Instale as dependências utilizando o gerenciador de pacotes (por exemplo, dotnet CLI): `dotnet restore`
4. Configure a conexão com o banco de dados SQL Server no arquivo `appsettings.json`.
5. Execute as migrações do banco de dados para criar as tabelas: `dotnet ef database update`
6. Inicie o servidor: `dotnet run`
7. Acesse o sistema através do seu navegador utilizando o seguinte endereço: `http://localhost:5000` (ou outra porta, se especificada).

## Contribuição:
Agradecemos muito o seu interesse em contribuir para o ERP Governador Store. Se você deseja colaborar com código, correções de bugs ou novas funcionalidades, siga as orientações abaixo:
1. Crie um fork deste repositório.
2. Crie uma branch para a sua feature ou correção: `git checkout -b minha-feature`.
3. Implemente as alterações desejadas e faça um commit: `git commit -m 'Minha contribuição: resolvo x'.
4. Envie as alterações para o seu fork: `git push origin minha-feature`.
5. Crie um novo pull request, descrevendo detalhadamente as alterações propostas.

## Contato:
Se você tiver alguma dúvida, sugestão ou precisar de suporte, entre em contato comigo:
- Nome: Alexandre dos Santos Fagundes 😄
- E-mail: alexandrefagundes2014@hotmail.com 📧

-----------------------------------------------------------------------------------------------------------------

ENGLISH
# ERP Governador Store

## Project Description:
The ERP Governador Store is a comprehensive and powerful Enterprise Resource Planning (ERP) system, developed using .NET 7 with Razor Pages, Entity Framework, and Angular. It is designed to meet the needs of companies of all sizes and industries. The system provides a centralized solution to manage daily operations, including inventory control, billing, finance, human resources, and more. Additionally, it features integration with the Correios API for ZIP code lookup, facilitating logistics management. 🚀

## Key Features:
- Inventory Control: Comprehensive stock management, inventory tracking, low-stock alerts, and automated restocking. 📦
  
*The ERP Governador Store is designed with a modular structure, and additional modules like Sales, Finance, and others are planned for future development.* 🔮

## Technologies Used:
- .NET 7: The development platform used to build the ERP Governador Store.
- Entity Framework: Object-Relational Mapping (ORM) framework that simplifies data access and manipulation in the database.
- Razor Pages: Web programming approach based on pages, making it easy to develop user interfaces.
- Angular: JavaScript framework for building user interfaces, used to create the ERP's front-end.
- SQL Server: Database management system used to store ERP data.
- Integration with Correios API: Used to retrieve ZIP code information and streamline logistics management.

## Installation and Configuration:
To run the ERP Governador Store on your local machine, follow these steps:
1. Clone this repository to your development environment: `git clone https://github.com/alexandrefgs/ERPGovernadorStore`
2. Navigate to the project directory: `cd erp-governador-store`
3. Install dependencies using the package manager (e.g., dotnet CLI): `dotnet restore`
4. Install Angular dependencies: `npm install` or `yarn install`
5. Configure the SQL Server database connection in the `appsettings.json` file.
6. Run database migrations to create tables: `dotnet ef database update`
7. Start the .NET server: `dotnet run`
8. In another terminal window, start the Angular server: `ng serve`
9. Access the ERP through your browser using the following address: `http://localhost:4200` (or another port, if specified).

## Contribution:
We greatly appreciate your interest in contributing to the ERP Governador Store. If you would like to collaborate with code, bug fixes, or new features, follow these guidelines:
1. Fork this repository.
2. Create a branch for your feature or fix: `git checkout -b my-feature`.
3. Implement the desired changes and commit: `git commit -m 'My contribution: resolve x'.
4. Push the changes to your fork: `git push origin my-feature`.
5. Create a new pull request, providing detailed information about the proposed changes.

## Contact:
If you have any questions, suggestions, or need support, feel free to contact me:
- Name: Alexandre dos Santos Fagundes 😄
- Email: alexandrefagundes2014@hotmail.com 📧
