# 🚀 Roadmap Dev – Jornada de Aprendizado em Desenvolvimento

Repositório criado para documentar minha evolução como desenvolvedor, passando por todas as etapas fundamentais — da **lógica de programação** ao **desenvolvimento de APIs** completas com C# e SQL Server.

---

## 🧠 Etapa 1 — Fundamentos de Lógica

**Objetivo:** consolidar o raciocínio lógico e aplicar estruturas básicas da programação.

📁 Diretório: `Etapa1_Logica/`

### 🔹 Exercícios desenvolvidos:
- **Soma:** recebe dois números e exibe o resultado.
- **Par ou Ímpar:** identifica se o número inserido é par ou ímpar.
- **Tabuada:** imprime a tabuada de 1 a 10 de um número informado pelo usuário.
- **Verificar Maior Número:** compara três números e mostra o maior.
- **Média de Notas:** calcula a média de três notas e exibe “Aprovado” ou “Reprovado”.
- **Crescente:** imprime números de 1 a 10 usando `while`.
- **Números Primos:** lista os números primos até o valor informado.
- **Fatorial:** calcula o fatorial de um número inteiro.

🧩 Todos os métodos foram testados via `Program.cs` para garantir funcionamento e compreensão das estruturas condicionais (`if/else`) e de repetição (`for`, `while`).

---

## 🗃️ Etapa 2 — SQL

**Objetivo:** praticar consultas e manipulação de dados no SQL Server.

📁 Diretório: `Etapa2_SQL/`

### 🏗️ Estrutura:
- **create_table.sql:** criação do banco `EmpresaDB` com tabelas `Funcionarios` e `Departamentos`.
- **insert.sql:** inserção de registros de exemplo.
- **select.sql:** consultas com `SELECT`, `WHERE`, `ORDER BY`, `COUNT`, `AVG`, entre outras.
- **update.sql:** comandos de `UPDATE` e `DELETE` para simular rotinas de manutenção.

🧠 Essa etapa reforçou conceitos de **chave primária**, **chave estrangeira**, **filtragem de dados** e **ordenação**.

---

## 💻 Etapa 3 — C# Orientado a Objetos

**Objetivo:** aplicar os conceitos de orientação a objetos e boas práticas.

📁 Diretório: `Etapa3_CSharp/`

### 📒 Projeto: ContaBancaria
- Classes **Cliente** e **ContaBancaria** com propriedades (`Nome`, `CPF`, `Saldo`, etc.).
- Métodos de **depósito**, **saque** e **exibição de dados** com verificações (`if/else`).
- Instanciação de objetos via `Program` e testes com entradas manuais.

### 🗓️ Projeto: Agenda
- Classe **Compromisso** com `Nome`, `Telefone` e `Data`.
- Validação de datas e exibição de compromissos agendados.
- Estruturas de repetição e condicionais aplicadas para controle lógico.

---

## 🌐 Etapa 4 — Consumo e Criação de API

**Objetivo:** entender como consumir e criar APIs REST utilizando C# e Entity Framework Core.

📁 Diretório: `Etapa4_API/`

### 🔸 Projeto: ConsumindoAPI
- Aplicação console que consome dados de usuários da API pública  
  👉 [`https://jsonplaceholder.typicode.com/users`](https://jsonplaceholder.typicode.com/users)
- Uso de `HttpClient` para requisições HTTP (`GET`, `POST`, `PUT`, `DELETE`).

### 🔸 Projeto: GerenciadorDeDispositivosAPI
- API construída com **.NET 8 + Entity Framework + SQL Server**.
- `DbContext` configurado para gerenciar dados de **Dispositivos**.
- Endpoints criados no `DispositivosController`:
  - `GET /api/dispositivos` → lista todos os dispositivos
  - `GET /api/dispositivos/{id}` → retorna um dispositivo específico
  - `POST /api/dispositivos` → adiciona um novo dispositivo
  - `PUT /api/dispositivos/{id}` → atualiza um dispositivo existente
  - `DELETE /api/dispositivos/{id}` → exclui um dispositivo

🧰 Aplicando princípios de **código limpo**, **injeção de dependência** e **boas práticas REST**.

---

## 📈 Conclusão

Esse projeto foi desenvolvido com o propósito de **praticar e documentar** o aprendizado de forma contínua.  
Cada etapa representa um passo importante rumo à consolidação como **desenvolvedor full stack**.

---

## 🧑‍💻 Autor

**Tiago Ribeiro**  
🎓 Estudante de Análise e Desenvolvimento de Sistemas  
💼 Aspirante a Desenvolvedor Backend / Full Stack  

📎 [GitHub](https://github.com/18tiagoribeiro)  
🔗 [LinkedIn](https://www.linkedin.com/in/tiago-ribeiro-04744118a/)

---

> 💬 “O código é o reflexo da nossa forma de pensar. Quanto mais aprendemos, mais limpo ele se torna.”
