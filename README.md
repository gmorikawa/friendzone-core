# Friendzone

A minimal ASP.NET Core API targeting .NET 10.

## Start up

This project was generate using the `dotnet new` command with the `web` template.

```
dotnet new web
```

## Run

Install the .NET 10 SDK, then run:

```sh
dotnet run --urls http://localhost:5000
```

`GET http://localhost:5000/` returns HTTP 200 with the plain text body `Hello World`.

## Build

```sh
dotnet build
```

## Project Structure

Source code lives under `src/`, while `Friendzone.csproj` stays at the repository root. Run and build commands above still work from the repository root.

```text
Friendzone.csproj
src/
├── Program.cs
├── Core/
└── Http/
    ├── Controllers/
    └── Middlewares/
```

- `src/Program.cs` configures and starts the application.
- `src/Http/` represents the Presentation layer. It contains controllers that handle HTTP requests and return responses, along with HTTP middleware.
- `src/Core/` contains the domain objects that represent the application's business concepts and rules.
