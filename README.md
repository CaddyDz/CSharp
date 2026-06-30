# Databases

A small **.NET 8 console application** demonstrating the fundamentals of
[Entity Framework Core](https://learn.microsoft.com/ef/core/) with a
[SQLite](https://www.sqlite.org/) database using a **code-first** approach.

It is a learning/example project that shows how to:

- Define an entity using data annotations.
- Configure a `DbContext` with the EF Core Fluent API (table mapping, unique
  indexes, SQL default values).
- Create a SQLite database, seed it with data, and query it back.

## What it does

When run, the program:

1. Deletes any existing `TestDatabase.db` file so each run starts fresh.
2. Creates the database from the model via `EnsureCreated()`.
3. Seeds three sample `Product` rows (only if the table is empty).
4. Reads every product back and prints it to the console.
5. Waits for a key press before exiting.

Example output:

```text
Product ID = 1	Title=Product 1	Product 2 subtitle	Date added=6/30/2026 12:21:56 PM
Product ID = 2	Title=Product 2	Product 2 subtitle	Date added=6/30/2026 12:21:56 PM
Product ID = 3	Title=Product 3	Product 2 subtitle	Date added=6/30/2026 12:21:56 PM
```

## Project structure

| File | Purpose |
| --- | --- |
| `program.cs` | Application entry point — creates the database, seeds data, and prints products. |
| `MyDbContext.cs` | The EF Core `DbContext`. Configures the SQLite connection and maps the `Product` entity (table name, unique index on `title`, `CURRENT_TIMESTAMP` default for `created_at`). |
| `Models/Product.cs` | The `Product` entity (`id`, `title`, `sub_title`, `created_at`) with `[Key]`, `[Required]`, and `[MaxLength]` data annotations. |
| `Databases.csproj` | Project file targeting `net8.0` with the EF Core SQLite and Design package references. |

### The data model

`Product` maps to a table named `products` and has the following columns:

| Column | Type | Notes |
| --- | --- | --- |
| `id` | `int` | Primary key. |
| `title` | `string` | Required, max length 128, **unique index**. |
| `sub_title` | `string` | Required, max length 256. |
| `created_at` | `DateTime` | Required, defaults to SQL `CURRENT_TIMESTAMP`. |

> **Note:** `MyDbContext` maps the entity with a `test` schema
> (`ToTable("products", "test")`). SQLite has no concept of schemas, so the
> EF Core SQLite provider simply ignores it — the table is created as
> `products`.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later.

This project targets the .NET 8 LTS, which has native support for Windows,
Linux, and macOS (both Intel and Apple Silicon).

## Getting started

Clone the repository and run the app from the project root:

```bash
dotnet run
```

To build without running:

```bash
dotnet build
```

The first run creates a `TestDatabase.db` SQLite file in the working directory.
You can inspect it with any SQLite client, for example:

```bash
sqlite3 TestDatabase.db "SELECT * FROM products;"
```

## How it works

EF Core builds the model from `MyDbContext` and the `Product` entity:

- **Connection** — `MyDbContext.OnConfiguring` uses
  `optionsBuilder.UseSqlite("Filename=TestDatabase.db")`.
- **Mapping** — `MyDbContext.OnModelCreating` maps the table name, adds a unique
  index on `title`, and sets the `created_at` default to `CURRENT_TIMESTAMP`.
- **Schema creation** — `EnsureCreated()` creates the database and tables from
  the model (note: this is a quick way to get started but is not the same as
  using migrations).

## Next steps / ideas

- Replace `EnsureCreated()` with [EF Core migrations](https://learn.microsoft.com/ef/core/managing-schemas/migrations/)
  for versioned schema changes.
- Add more entities and relationships.
- Add update/delete operations to complete the CRUD examples.
