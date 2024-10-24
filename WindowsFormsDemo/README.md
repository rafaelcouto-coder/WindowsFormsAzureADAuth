# WindowsFormsAzureADAuth

## Projeto de Autentica��o com Azure AD em Aplica��o Windows Forms (.NET Framework 4.8)

Este reposit�rio cont�m um projeto de exemplo desenvolvido em .NET Framework 4.8 que demonstra como implementar autentica��o de usu�rios utilizando o Azure Active Directory (Azure AD) em uma aplica��o Windows Forms. 

## Funcionalidades Principais

- **Autentica��o com Azure AD**: Integra��o com o Azure Active Directory para autentica��o segura de usu�rios.
- **Interface de Usu�rio Simples**: Exemplo de interface de usu�rio com uma tela inicial de boas-vindas ap�s a autentica��o.
- **Fluxo de Autentica��o Autom�tica**: A autentica��o � iniciada automaticamente ao iniciar a aplica��o, sem a necessidade de uma tela de login intermedi�ria.

## Tecnologias Utilizadas

- **.NET Framework 4.8**: Plataforma de desenvolvimento utilizada para criar a aplica��o Windows Forms.
- **Microsoft Authentication Library (MSAL)**: Biblioteca utilizada para integrar a autentica��o com o Azure AD.

## Como Executar

1. **Clone o Reposit�rio**:
   
2. **Abra o Projeto no Visual Studio**:
   - Abra o arquivo `.sln` no Visual Studio.

3. **Configurar o Azure AD**:
   - Substitua `your-client-id` e `your-tenant-id` no c�digo pelo Client ID e Tenant ID do seu aplicativo registrado no Azure AD.

4. **Executar a Aplica��o**:
   - Compile e execute a aplica��o no Visual Studio.

## Estrutura do Projeto

- **Program.cs**: Cont�m a l�gica de inicializa��o da aplica��o e a autentica��o com Azure AD.
- **Home.cs**: Formul�rio de boas-vindas exibido ap�s a autentica��o bem-sucedida.
- **Home.Designer.cs**: C�digo gerado automaticamente para o design do formul�rio `Home`.

## Contribui��es

Contribui��es s�o bem-vindas! Sinta-se � vontade para abrir issues e pull requests para melhorias e corre��es.

## Licen�a

Este projeto est� licenciado sob a [MIT License](LICENSE).
