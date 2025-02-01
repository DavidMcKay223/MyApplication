# MyApplication
[Source Code](https://github.com/DavidMcKay223/MyApplication/tree/main/report/MyApp.Report.Output/Class)

## Clean Architecture: Overview
```
  src/
  ├── MyApp.Web/                  # Blazor Presentation Layer
  ├── MyApp.Application/          # Use Cases, MediatR, DTOs
  ├── MyApp.Domain/               # Entities, Interfaces
  ├── MyApp.Infrastructure/       # EF Core, Repositories
  ├── MyApp.Shared/               # Shared components, base classes
tests/
  ├── MyApp.Web.Tests/            # Unit tests for Blazor components
  ├── MyApp.Application.Tests/    # Unit tests for use cases
  ├── MyApp.Domain.Tests/         # Unit tests for domain logic
  ├── MyApp.Infrastructure.Tests/ # Unit tests for repositories
  └── MyApp.Shared.Tests/         # Unit tests for shared utilities
```

## Project References: Dependencies
```
src/
  ├── MyApp.Web/
  ├──── Includes: MyApp.Application
  ├──── Includes: MyApp.Infrastructure
  ├──── Includes: MyApp.Shared
  ├──── Includes: Microsoft.EntityFrameworkCore
  ├──── Includes: Microsoft.EntityFrameworkCore.Design
  ├──── Includes: Microsoft.EntityFrameworkCore.SqlServer
  ├── MyApp.Application/
  ├──── Includes: MyApp.Domain
  ├──── Includes: MyApp.Shared
  ├── MyApp.Domain/
  ├──── No Dependencies
  ├── MyApp.Infrastructure/
  ├──── Includes: MyApp.Domain
  ├──── Includes: MyApp.Shared
  ├──── Includes: Microsoft.EntityFrameworkCore
  ├──── Includes: Microsoft.EntityFrameworkCore.Design
  ├──── Includes: Microsoft.EntityFrameworkCore.SqlServer
  ├──── Includes: Microsoft.EntityFrameworkCore.Tools
  ├── MyApp.Shared/
  ├──── No Dependencies
```
