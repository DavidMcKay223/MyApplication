# AppDbContext

**Namespace:** `MyApp.Infrastructure.Persistence`

**File Path:** `MyApp.Infrastructure/Persistence/AppDbContext .cs`

## Inherits From

- `DbContext`

## Methods

- `protected` `void OnConfiguring(DbContextOptionsBuilder optionsBuilder)`
- `protected` `void OnModelCreating(ModelBuilder modelBuilder)`
- `private` `void ConfigureMusicEntities(ModelBuilder modelBuilder)`
- `private` `void ConfigureMedicalEntities(ModelBuilder modelBuilder)`
- `private` `void ConfigureClaimEntity(EntityTypeBuilder<Claim> entity)`
- `private` `void ConfigureOwnedProperties(EntityTypeBuilder<Claim> entity)`
- `private` `void ConfigureClaimRelationships(EntityTypeBuilder<Claim> entity)`

