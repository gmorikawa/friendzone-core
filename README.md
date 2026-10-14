# Friendzone API

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
