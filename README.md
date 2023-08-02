# ERP Governador Store

## Descrição do Projeto

O ERP Governador Store é um Sistema de Gestão Empresarial (ERP) completo e poderoso, desenvolvido utilizando a plataforma .NET 7 com Razor Pages e Entity Framework.
Ele foi projetado para atender às necessidades de empresas de todos os tamanhos e segmentos.
O sistema fornece uma solução centralizada para gerenciar as operações diárias, incluindo controle de estoque, faturamento, finanças, recursos humanos e muito mais.
Além disso, possui integração com a API dos correios para busca de CEPs, o que facilita a gestão logística.

## Funcionalidades Principais

- Controle de Estoque: Gerenciamento abrangente do estoque, controle de inventário, alertas de estoque baixo e reabastecimento automatizado.

*Outros módulos de operação estão sendo desenvolvidos e serão disponibilizados futuramente.*

## Tecnologias Utilizadas

- .NET 7: Plataforma de desenvolvimento utilizada para criar o sistema ERP Governador Store.
- Entity Framework: Framework ORM (Object-Relational Mapping) que facilita o acesso e manipulação de dados no banco de dados.
- Razor Pages: Abordagem de programação web baseada em páginas que facilita o desenvolvimento de interfaces de usuário.
- SQL Server: Sistema de gerenciamento de banco de dados utilizado para armazenar os dados do ERP.
- Integração com API dos Correios: Utilizada para obter informações de CEPs e facilitar a gestão logística.

## Instalação e Configuração

Para executar o ERP Governador Store em sua máquina local, siga os passos abaixo:

1. Faça um clone deste repositório para o seu ambiente de desenvolvimento: `git clone https://github.com/alexandrefgs/ERPGovernadorStore`
2. Navegue até o diretório do projeto: `cd erp-governador-store`
3. Instale as dependências utilizando o gerenciador de pacotes (por exemplo, dotnet CLI): `dotnet restore`
4. Configure a conexão com o banco de dados SQL Server no arquivo `appsettings.json`.
5. Execute as migrações do banco de dados para criar as tabelas: `dotnet ef database update`
6. Inicie o servidor: `dotnet run`
7. Acesse o sistema através do seu navegador utilizando o seguinte endereço: `http://localhost:5000` (ou outra porta, se especificada).

## Contribuição

Agradecemos muito o seu interesse em contribuir para o ERP Governador Store. Se você deseja colaborar com código, correções de bugs ou novas funcionalidades, siga as orientações abaixo:

1. Crie um fork deste repositório.
2. Crie uma branch para a sua feature ou correção: `git checkout -b minha-feature`.
3. Implemente as alterações desejadas e faça um commit: `git commit -m 'Minha contribuição: resolvo x'.
4. Envie as alterações para o seu fork: `git push origin minha-feature`.
5. Crie um novo pull request, descrevendo detalhadamente as alterações propostas.

## Contato

Se você tiver alguma dúvida, sugestão ou precisar de suporte, entre em contato comigo:

- Nome: Alexandre dos Santos Fagundes
- E-mail: alexandrefagundes2014@hotmail.com

---

*Agradecemos a todos os contribuidores que ajudaram a tornar este projeto possível.*

