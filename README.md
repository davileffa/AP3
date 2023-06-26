Biblioteca API
Este projeto é uma API RESTful para um sistema de gerenciamento de biblioteca.

Tecnologias utilizadas
ASP.NET Core Web API
Entity Framework Core
AutoMapper
Configuração
Clone o repositório para sua máquina local.
Certifique-se de ter o .NET SDK instalado (versão X.X.X).
Navegue até o diretório do projeto e execute o comando dotnet restore para restaurar as dependências.
Configure a string de conexão do banco de dados no arquivo appsettings.json.
Execute o comando dotnet ef database update para aplicar as migrações e criar o banco de dados.
Execute o comando dotnet run para iniciar a API.
Funcionalidades
A API oferece as seguintes funcionalidades:

Gerenciamento de livros: CRUD de livros, incluindo a associação de autores.
Gerenciamento de autores: CRUD de autores.
Gerenciamento de usuários: CRUD de usuários e operações de empréstimo e devolução de livros.
Endpoints
A seguir estão os endpoints disponíveis na API:

Livros
GET /api/livros: Retorna todos os livros.
GET /api/livros/{id}: Retorna um livro específico com base no ID.
POST /api/livros: Cria um novo livro.
PUT /api/livros/{id}: Atualiza um livro existente com base no ID.
DELETE /api/livros/{id}: Exclui um livro existente com base no ID.
Autores
GET /api/autores: Retorna todos os autores.
GET /api/autores/{id}: Retorna um autor específico com base no ID.
POST /api/autores: Cria um novo autor.
PUT /api/autores/{id}: Atualiza um autor existente com base no ID.
DELETE /api/autores/{id}: Exclui um autor existente com base no ID.
Usuários
GET /api/usuarios: Retorna todos os usuários.
GET /api/usuarios/{id}: Retorna um usuário específico com base no ID.
POST /api/usuarios: Cria um novo usuário.
PUT /api/usuarios/{id}: Atualiza um usuário existente com base no ID.
DELETE /api/usuarios/{id}: Exclui um usuário existente com base no ID.
Empréstimos
POST /api/emprestimo: Realiza um empréstimo de um livro por um usuário. Requer um corpo JSON contendo as informações do empréstimo.
Devoluções
POST /api/devolucao: Realiza a devolução de um livro por um usuário. Requer um corpo JSON contendo as informações da devolução.
Exemplos de solicitações HTTP
Aqui estão alguns exemplos de solicitações HTTP que podem ser feitas para a API:

Recuperar todos os livros:

bash
Copy code
GET /api/livros
Criar um novo livro:

bash
Copy code
POST /api/livros
Content-Type: application/json

{
  "Titulo": "Livro Teste",
  "AutorId": 1,
  "ISBN": "9781234567890",
  "AnoPublicacao": 2022
}
Atualizar um livro existente:

bash
Copy code
PUT /api/livros/{id}
Content-Type: application/json

{
  "Titulo": "Novo Título"
}
Excluir um livro existente:

bash
Copy code
DELETE /api/livros/{id}
Certifique-se de substituir {id} pelos IDs reais dos recursos correspondentes.