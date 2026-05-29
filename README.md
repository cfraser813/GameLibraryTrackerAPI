# Game Library Tracker

A RESTful API built with ASP.NET Core and Entity Framework Core which allows for game cataloguing. You are able to create, read, update and delete entries from a frontend webpage.

## Tech Stack
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- HTML/JavaScript frontend

## Getting Started

### Prerequisites
- Visual Studio 2022
- SQL Server Express
- .NET 8
- Visual Studio Code (If you want to run the frontend I include)

### Setup
1. Clone the repository
2. Update the connection string in `appsettings.json` to point to your SQL Server instance
3. Run `Update-Database` in Package Manager Console to create the database
4. Run the project - Swagger UI will be available at `https://localhost:{port}/swagger` or just run the frontend on a VSC live server.

## API Endpoints
- `GET /api/Games` - Get all games
- `POST /api/Games` - Add a new game
- `PUT /api/Games/{id}` - Update a game
- `DELETE /api/Games/{id}` - Delete a game
