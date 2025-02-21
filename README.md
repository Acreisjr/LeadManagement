# **Lead Management API e Frontend**

Este projeto consiste em uma API para gerenciamento de leads e uma interface frontend para exibição e manipulação dos dados. Ele implementa **CQRS** e **MediatR**, garantindo uma arquitetura escalável e modular.

---

## 📌 **Pré-requisitos**
Antes de rodar o projeto, certifique-se de ter instalado:

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Node.js](https://nodejs.org/)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Visual Studio Code](https://code.visualstudio.com/), [Visual Studio](https://visualstudio.microsoft.com/) ou uma IDE de sua preferência

---

## 🚀 **Rodando o Backend (API)**
### **1️⃣ Configurar o Banco de Dados**
O backend utiliza **SQL Server** para armazenamento dos leads. Se ainda não possui um banco de dados configurado, siga os passos abaixo:

1. **Criar o banco de dados manualmente**:
   - Acesse o SQL Server e crie um banco de dados chamado **LeadDB**:
     ```sql
     CREATE DATABASE LeadDB;
     ```
   - Se necessário, ajuste o **usuário** e **senha** no arquivo `appsettings.json`:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=LeadDB;User Id=sa;Password=SuaSenhaAqui;TrustServerCertificate=True;"
     }
     ```

2. **Rodar as migrations** para criar as tabelas e popular o banco com dados de teste:
   ```sh
   dotnet ef database update
   ```

---

### **2️⃣ Iniciar a API**
Para rodar a API, execute os seguintes comandos no terminal:

```sh
cd LeadManagementAPI
dotnet run
```
A API estará disponível em **`http://localhost:7139`**.

📌 **Swagger UI disponível em**:
👉 [`https://localhost:7140/swagger/index.html`](https://localhost:7140/swagger/index.html)

---

## 🎨 **Rodando o Frontend (React)**
### **1️⃣ Instalar dependências**
No diretório do frontend, execute:

```sh
cd lead-management-frontend
npm install
```

### **2️⃣ Iniciar o servidor de desenvolvimento**
```sh
npm start
```
O frontend estará disponível em **`http://localhost:3000`**.

---

## 🛠 **Leads criados automaticamente**:
Os seguintes **leads de teste** serão inseridos automaticamente no banco de dados na primeira execução:

| ID | Nome            | Sobrenome | Cidade         | Categoria   | Descrição                            | Preço  | Status  |
|----|---------------|-----------|---------------|------------|-------------------------------------|--------|---------|
| 1  | John         | Doe       | New York      | Plumbing   | Fix a broken pipe in the bathroom. | $150.00 | Invited |
| 2  | Alice        | Smith     | Los Angeles   | Painting   | Paint the living room.             | $250.00 | Invited |
| 3  | Bob         | Johnson   | Chicago       | Electrical | Install new ceiling lights.        | $350.00 | Accepted |
| 4  | Emma        | Williams  | San Francisco | Carpentry  | Build a custom bookshelf.          | $400.00 | Accepted |
| 5  | Michael     | Brown     | Miami         | Landscaping| Design and plant a garden.        | $600.00 | Invited |
| 6  | Sophia      | Miller    | Boston        | Cleaning   | Deep clean a 3-bedroom apartment. | $200.00 | Invited |
| 7  | Daniel      | Garcia    | Seattle       | Roofing    | Repair damaged roof shingles.     | $750.00 | Declined |
| 8  | Olivia      | Davis     | Dallas        | Plumbing   | Replace a leaking kitchen faucet.  | $180.00 | Invited |

📌 **Caso queira adicionar mais leads manualmente, use o Swagger UI (https://localhost:7140/swagger/index.html) ou um cliente de banco de dados para inseri-los diretamente.**

---

## 🛠️ **Principais Tecnologias Utilizadas**
✅ **Backend**:
- .NET 6.0
- Entity Framework Core 6.0
- SQL Server
- CQRS + MediatR

✅ **Frontend**:
- React.js + TypeScript
- Componentização
- FontAwesome para ícones

---
📌 **Criado por:** [Alberto da Costa Reis Júnior]  
📆 **Última atualização:** [21/02/2025]
