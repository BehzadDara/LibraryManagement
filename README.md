# LibraryManagement

🚀 **LibraryManagement** is a project built using **GraphQL** for efficient data operations, with **SQL Server** and **EF Core** for database management. It provides a flexible system for managing books, authors, and users in a library setting.

---

## ⭐ Star This Repository!

---

## 🔧 What's Inside?

- **GraphQL** for powerful and flexible querying and mutation operations
- **SQL Server** and **EF Core** for seamless database access
- Built-in **GraphQL Dashboard** for easy querying and testing of the API

---

## 📝 How to Use It

1. Run the project.
2. Use the GraphQL dashboard to interact with the API.
3. Perform the following operations:
   - **Mutations**: Add new users, authors, and books.
   - **Queries**: Fetch lists of users, books, and authors, and search users by name.

---

## 👉 Sample Mutations and Queries

## 1. AddUser

```graphql
mutation {
  addUser(name: "Behzad User") {
    id
    name
  }
}
```

## 2. AddAuthor

```graphql
mutation {
  addAuthor(name: "Behzad Author") {
    id
    name
  }
}
```

## 3. AddBook

```graphql
 mutation {
   addBook(input: { title: "My Book", isbn: "1234567890", authorId: 1 }) {
     id
     title
   }
 }
```

## 4. GetAuthors

```graphql
query {
  authors {
    id
    name
  }
}
```

## 5. GetBooks

```graphql
query {
  books{
    id,
    title,
    isbn,
    authorId
    author {
      name
    }
  }
}
```

## 6. GetUsers

```graphql
query{
  users(q: "Behzad"){
    id
    name
    borrowedBooks{
      id
      title
      isbn
      author{
        id
        name
        }
      }
    }
  }
```

![Sample Get Users Query](./LibraryManagement.png)

---

## 🛠 Contribution

### 1. Complete CRUD Operations for Entities
   - Currently, the system allows the addition of users, authors, and books. Contributions are welcome to implement full CRUD operations for these entities.

### 2. Add Authentication and Authorization
   - Help enhance the project by adding authentication and authorization mechanisms, and secure the GraphQL endpoints with headers.

---

## Stay Connected

- **GitHub**: [BehzadDara](https://github.com/BehzadDara)
- **LinkedIn**: [Behzad Dara](https://www.linkedin.com/in/behzaddara/)
