# AppDbContext

**Namespace:** `MyApp.Infrastructure.Persistence`

**File Path:** `MyApp.Infrastructure/Persistence/AppDbContext .cs`

## Inherits From

- `DbContext`

## Properties

- `DbSet<Album> Albums`
- `DbSet<CD> CDs`
- `DbSet<Track> Tracks`
- `DbSet<TaskItem> TaskItems`
- `DbSet<Claim> Claims`
- `DbSet<Address> Addresses`
- `DbSet<DiagnosisCode> DiagnosisCodes`
- `DbSet<ServiceLine> ServiceLines`

## Methods

- `protected` `void OnConfiguring(DbContextOptionsBuilder optionsBuilder)`
- `protected` `void OnModelCreating(ModelBuilder modelBuilder)`
- `private` `void ConfigureMusicEntities(ModelBuilder modelBuilder)`
- `private` `void ConfigureMedicalEntities(ModelBuilder modelBuilder)`
- `private` `void ConfigureClaimEntity(EntityTypeBuilder<Claim> entity)`
- `private` `void ConfigureOwnedProperties(EntityTypeBuilder<Claim> entity)`
- `private` `void ConfigureClaimRelationships(EntityTypeBuilder<Claim> entity)`

