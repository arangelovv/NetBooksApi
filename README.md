# Books REST API
A .NET-based REST API for managing a collection of books. This project serves as a learning resource for understanding REST API development with .NET.

## Features

- CRUD operations for books
- JSON request/response format
- Input validation
- Proper HTTP status codes
- Error handling
- RESTful design principles

## Getting Started

1. Clone the repository:
```bash
git clone [your-repository-url]
cd BooksApi
```

2. Run the application:
```bash
dotnet run
```
The API will be available at `https://localhost:5291`.

## API Endpoints

#### GET /books
- **Purpose**: Retrieve a list of all books
- **Response**: JSON array of book objects
- **Status Code**: 200 OK

#### GET /books/{id}
- **Purpose**: Retrieve detailed information for a single book
- **Response**: JSON object representing the book details
- **Status Code**: 200 OK
- **Error**: 404 Not Found if book doesn't exist

#### POST /books
- **Purpose**: Create a new book record
- **Request**: JSON object with book data
- **Response**: Newly created book object
- **Status Code**: 201 Created
- **Error**: 400 Bad Request if validation fails

#### PUT /books/{id}
- **Purpose**: Update an existing book's information
- **Request**: JSON object with updated fields
- **Response**: Updated book object
- **Status Code**: 200 OK
- **Error**: 404 Not Found if book doesn't exist

#### DELETE /books/{id}
- **Purpose**: Remove a book from the collection
- **Response**: No content
- **Status Code**: 204 No Content
- **Error**: 404 Not Found if book doesn't exist

### Book Entity
```json
{
    "id": "guid",
    "title": "string",
    "author": "string",
    "publicationDate": "date",
    "isbn": "string (optional)",
    "genre": "string (optional)",
    "summary": "string (optional)",
    "publisher": "string (optional)"
}
```
