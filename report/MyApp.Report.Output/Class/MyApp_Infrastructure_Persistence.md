# Namespace: `MyApp.Infrastructure.Persistence`

## Class: `AppDbContext`

- **File Path:** `MyApp.Infrastructure/Persistence/AppDbContext .cs`
- **Inherits From:** `DbContext`

### Properties

| Name | Type |
|------|------|
| `Albums` | `DbSet<Album>` |
| `CDs` | `DbSet<CD>` |
| `Tracks` | `DbSet<Track>` |
| `TaskItems` | `DbSet<TaskItem>` |
| `Claims` | `DbSet<Claim>` |
| `Addresses` | `DbSet<Address>` |
| `DiagnosisCodes` | `DbSet<DiagnosisCode>` |
| `ServiceLines` | `DbSet<ServiceLine>` |

### Methods

| Name | Return Type | Access Modifier | Static | Parameters |
|------|-------------|-----------------|--------|------------|
| `OnConfiguring` | `void` | `protected` | `No` | `DbContextOptionsBuilder optionsBuilder` |
| `OnModelCreating` | `void` | `protected` | `No` | `ModelBuilder modelBuilder` |
| `ConfigureMusicEntities` | `void` | `private` | `No` | `ModelBuilder modelBuilder` |
| `ConfigureMedicalEntities` | `void` | `private` | `No` | `ModelBuilder modelBuilder` |
| `ConfigureClaimEntity` | `void` | `private` | `No` | `EntityTypeBuilder<Claim> entity` |
| `ConfigureOwnedProperties` | `void` | `private` | `No` | `EntityTypeBuilder<Claim> entity` |
| `ConfigureClaimRelationships` | `void` | `private` | `No` | `EntityTypeBuilder<Claim> entity` |

