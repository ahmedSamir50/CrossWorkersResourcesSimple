dotnet ef migrations add InitialCreate --context ResourcesSqliteContext --output-dir Migrations/SqliteMigrations --project DataAccess

dotnet ef database update --context ResourcesSqliteContext --project DataAccess -- --Provider SQLLite