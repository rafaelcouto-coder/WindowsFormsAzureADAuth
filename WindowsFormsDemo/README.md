# WindowsFormsAzureADAuth

## Projeto de Autenticação com Azure AD em Aplicação Windows Forms (.NET Framework 4.8)

Este repositório contém um projeto de exemplo desenvolvido em .NET Framework 4.8 que demonstra como implementar autenticação de usuários utilizando o Azure Active Directory (Azure AD) em uma aplicação Windows Forms. 

## Funcionalidades Principais

- **Autenticação com Azure AD**: Integração com o Azure Active Directory para autenticação segura de usuários.
- **Interface de Usuário Simples**: Exemplo de interface de usuário com uma tela inicial de boas-vindas após a autenticação.
- **Fluxo de Autenticação Automática**: A autenticação é iniciada automaticamente ao iniciar a aplicação, sem a necessidade de uma tela de login intermediária.

## Tecnologias Utilizadas

- **.NET Framework 4.8**: Plataforma de desenvolvimento utilizada para criar a aplicação Windows Forms.
- **Microsoft Authentication Library (MSAL)**: Biblioteca utilizada para integrar a autenticação com o Azure AD.

## Como Executar

1. **Clone o Repositório**:
   
2. **Abra o Projeto no Visual Studio**:
   - Abra o arquivo `.sln` no Visual Studio.

3. **Configurar o Azure AD**:
   - Substitua `your-client-id` e `your-tenant-id` no código pelo Client ID e Tenant ID do seu aplicativo registrado no Azure AD.

4. **Executar a Aplicação**:
   - Compile e execute a aplicação no Visual Studio.

## Estrutura do Projeto

- **Program.cs**: Contém a lógica de inicialização da aplicação e a autenticação com Azure AD.
- **Home.cs**: Formulário de boas-vindas exibido após a autenticação bem-sucedida.
- **Home.Designer.cs**: Código gerado automaticamente para o design do formulário `Home`.

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para melhorias e correções.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
