# CRUD Product IBID ASP.NET 6
## Descrição
Este é um projeto ASP.NET 6 que realiza um CRUD de Produto. O projeto foi desenvolvido para o ingresso ao Bootcamp da IBID

### Pré-requisitos
Antes de começar, certifique-se de ter as seguintes ferramentas instaladas:

- .NET 6 SDK
- Visual Studio Code (opcional, mas recomendado)
- SQL Server (ou outro banco de dados de sua escolha, se aplicável)

### Configuração do Banco de Dados

1. Crie um banco de dados para o projeto no SQL Server.
2. Atualize a string de conexão no arquivo appsettings.json para apontar para o seu banco de dados recém-criado.

Copy code
{
  "ConnectionStrings": {
    "DefaultConnection": "SuaStringDeConexaoAqui"
  },
  // Outras configurações
}
### Executando o Projeto
Para executar o projeto localmente, siga estas etapas:

1. Abra um terminal e navegue até a pasta raiz do projeto.

2. Execute o seguinte comando para restaurar as dependências do projeto:

```bash
dotnet restore
```
3. Aplique as migrações do banco de dados (se aplicável):

```bash
dotnet ef database update
```
4. Inicie o projeto com o seguinte comando:

```bash
dotnet run
```
5. Normalmente o Navegador principal do Sistema é aberto rodando a aplicação, mas caso não ocorra, abra um navegador da web e acesse http://localhost:5000 para ver o projeto em execução.
