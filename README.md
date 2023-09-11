# API de Livros:

Esta API permite gerenciar informações sobre livros, incluindo a capacidade de adicionar novos livros e buscar livros por ID.

<b> Método POST </b>

- O método POST é usado para adicionar um novo livro à base de dados.
- POST com os detalhes do livro, incluindo Name, Description e Author, no corpo da solicitação no formato JSON.
- A resposta da API geralmente inclui uma confirmação de sucesso ou o Id único atribuído ao novo livro.

```
{
  "Name": "O Senhor dos Anéis",
  "Description": "Uma emocionante aventura na Terra Média...",
  "Author": "J.R.R. Tolkien"
}
```

<br>
<br>

<b> Método GET </b>

- O método GET é usado para buscar informações sobre um livro com base no seu Id.
- O servidor verifica se o livro com o Id especificado existe na base de dados.
- Se o livro for encontrado, a API retorna os detalhes do livro, incluindo Name, Description e Author, em formato JSON.

```
GET /api/livros/123
```

<b> Dupla : </b> Emilynn Zabala e Polianna Abulquerque
