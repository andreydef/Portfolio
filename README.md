# Portfolio

[![License](https://img.shields.io/badge/license-GPL%203.0-blue)](https://github.com/andreydef/Portfolio/blob/master/LICENSE.md)

**Stack:**

- Angular 1.X
- ASP .NET Core(MVC)
- ADO .NET, LINQ
- SQL (SQL Server)
- Entity Framework --version Entity Framework: 6.4.0

## Development

To get started, you will need [Visual Studio](https://visualstudio.microsoft.com/ru/downloads/) and [Sql Server](https://www.microsoft.com/ru-ru/sql-server/sql-server-downloads) on your system.

### Install and open
* `git clone https://github.com/andreydef/Contrast_shop.git`
* `Open in Visual Studio`
* `Open package manager console`
* `Use this command to uninstall package`
```csharp
Uninstall-package Microsoft.CodeDom.Providers.DotNetCompilerPlatform
```

### Migrate database and run
* `Change to correct connection link to sql database in file Startup.cs`
```csharp
    string connectionString = "Data Source=DESKTOP-RV4PASN;Initial Catalog=Portfolio;Integrated Security=True;Trusted_Connection=True;"; // change to your connection string
```
* `Open package manager console`
* `Use this command to add migration`
```csharp
add-migration Name_migration
```

* `Got to ClientApp and install npm packages`
```csharp
    cd ClientApp
    npm install
```

Then, you can run the **.sln** in Visual Studion and build the project.

## License

[GPL-3.0 License](LICENSE)