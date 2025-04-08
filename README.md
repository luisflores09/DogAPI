# DogAPI

DogAPI is a .NET-based web API designed to manage and retrieve information about dogs. This project serves as a backend service for applications that require dog-related data, such as breed information, characteristics, or user-submitted dog profiles.

## Features

- **CRUD Operations**: Create, retrieve, update, and delete dog records.
- **PostgreSQL Integration**: Uses Entity Framework Core with PostgreSQL for database operations.
- **Environment Configuration**: Sensitive information like database credentials is stored in a `.env` file.

## Getting Started

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/)
- A tool like [Postman](https://www.postman.com/) or [HTTP Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) for testing API endpoints.

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo/DogAPI.git
   cd DogAPI
   ```
2. Restore dependencies:
   ```bash
   dotnet restore
   ```
3. Configure the Environment:
   Create a `.env` file in the root of the project and add the following content:
   ```
   ConnectionStrings__DefaultConnection=Host=localhost;Database=DogAPI;Username=postgres;Password=yourpassword
   ```
   Replace `yourpassword` with your PostgreSQL password.

### Running the Application

1. Apply database migrations:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
2. Start the API:
   ```bash
   dotnet run
   ```
3. The API will be available at http://localhost:5221 (or the port specified in the output).

### Usage

Use tools like [Postman](https://www.postman.com/) or `curl` to interact with the API. Example endpoints:

- `GET /api/dogs` - Retrieve all dogs.
- `POST /api/dogs` - Add a new dog.
- `PUT /api/dogs/{id}` - Update a dog's information.
- `DELETE /api/dogs/{id}` - Remove a dog.

### Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

### License

This project is licensed under the [MIT License](LICENSE).
