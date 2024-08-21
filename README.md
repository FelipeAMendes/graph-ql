
# GraphQL

Simples aplicação GraphQL utilizando a lib HotChocolate

## Exemplos

### Queries

```javascript
mutation {
  addBook(input: { title: "The Pragmatic Programmer", author: "David Thomas, Andrew Hunt", year: 2019 }) {
    id
    title
    author
    year
  }
  
  updateBook(id: 1, input: { title: "Clean Code", author: "Robert C. Martin", year: 2008 }) {
    id
    title
    author
    year
  }
  
  deleteBook(id: 1)
}
```

### Mutations

```javascript
mutation {
  addBook(input: { title: "The Pragmatic Programmer", author: "David Thomas, Andrew Hunt", year: 2019 }) {
    id
    title
    author
    year
  }
  
  updateBook(id: 1, input: { title: "Clean Code", author: "Robert C. Martin", year: 2008 }) {
    id
    title
    author
    year
  }
  
  deleteBook(id: 1)
}
```
