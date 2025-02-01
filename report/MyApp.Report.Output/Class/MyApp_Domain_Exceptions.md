# Namespace: `MyApp.Domain.Exceptions`

## Class: `BadRequestException`

- **File Path:** `MyApp.Domain/Exceptions/BadRequestException.cs`
- **Inherits From:** `Exception`

### Class Code

```csharp
public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message) { }
    }
```

## Class: `NotFoundException`

- **File Path:** `MyApp.Domain/Exceptions/NotFoundException.cs`
- **Inherits From:** `Exception`

### Class Code

```csharp
public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }

        public NotFoundException(string entityName, int id)
            : base($"'{entityName}' with ID {id} was not found.") { }
    }
```

