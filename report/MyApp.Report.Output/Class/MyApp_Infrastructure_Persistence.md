# Namespace: `MyApp.Infrastructure.Persistence`

## Class: `AppDbContext`

- **File Path:** `MyApp.Infrastructure/Persistence/AppDbContext .cs`
- **Inherits From:** `DbContext`

### Class Code

```csharp
public class AppDbContext : DbContext
{
    // Music Entities
    public DbSet<Album> Albums { get; set; }
    public DbSet<CD> CDs { get; set; }
    public DbSet<Track> Tracks { get; set; }

    // Management Entities
    public DbSet<TaskItem> TaskItems { get; set; }

    // Medical Entities
    public DbSet<Claim> Claims { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<DiagnosisCode> DiagnosisCodes { get; set; }
    public DbSet<ServiceLine> ServiceLines { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("DefaultConnection", options =>
                options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureMusicEntities(modelBuilder);
        ConfigureMedicalEntities(modelBuilder);
    }

    private void ConfigureMusicEntities(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Album>()
            .HasMany(a => a.CDs)
            .WithOne(c => c.Album)
            .HasForeignKey(c => c.AlbumId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CD>()
            .HasMany(c => c.Tracks)
            .WithOne(t => t.CD)
            .HasForeignKey(t => t.CDId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    private void ConfigureMedicalEntities(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Claim>(entity =>
        {
            ConfigureClaimEntity(entity);
        });
    }

    private void ConfigureClaimEntity(EntityTypeBuilder<Claim> entity)
    {
        // Configure complex properties
        ConfigureOwnedProperties(entity);

        // Configure relationships
        ConfigureClaimRelationships(entity);
    }

    private void ConfigureOwnedProperties(EntityTypeBuilder<Claim> entity)
    {
        // OtherInsurance (owned entity)
        entity.OwnsOne(c => c.OtherInsurance, oi =>
        {
            oi.Property(oi => oi.PolicyHolderName).HasMaxLength(50);
            oi.Property(oi => oi.PolicyNumber).HasMaxLength(20);
            oi.Property(oi => oi.PlanName).HasMaxLength(50);
        });

        // ConditionRelated (owned entity)
        entity.OwnsOne(c => c.ConditionRelated, cr =>
        {
            cr.Property(cr => cr.Employment);
            cr.Property(cr => cr.AutoAccident);
            cr.Property(cr => cr.OtherAccident);
            cr.Property(cr => cr.AccidentState).HasMaxLength(2);
        });

        // Patient (owned entity)
        entity.OwnsOne(c => c.Patient, p =>
        {
            p.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            p.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            p.Property(p => p.BirthDate).IsRequired();
            p.Property(p => p.Sex).IsRequired();
            p.OwnsOne(p => p.Address, a =>
            {
                a.ToTable("Medical_Claim_PatientAddress"); // Separate table for Patient Address
                a.Property(a => a.Street).HasMaxLength(100);
                a.Property(a => a.City).HasMaxLength(50);
                a.Property(a => a.State).HasMaxLength(2);
                a.Property(a => a.ZipCode).HasMaxLength(10);
                a.Property(a => a.Phone).HasMaxLength(20);
            });
        });

        // Insured (owned entity)
        entity.OwnsOne(c => c.Insured, i =>
        {
            i.Property(i => i.LastName).HasMaxLength(50).IsRequired();
            i.Property(i => i.FirstName).HasMaxLength(50).IsRequired();
            i.OwnsOne(i => i.Address, a =>
            {
                a.ToTable("Medical_Claim_InsuredAddress"); // Separate table for Insured Address
                a.Property(a => a.Street).HasMaxLength(100);
                a.Property(a => a.City).HasMaxLength(50);
                a.Property(a => a.State).HasMaxLength(2);
                a.Property(a => a.ZipCode).HasMaxLength(10);
                a.Property(a => a.Phone).HasMaxLength(20);
            });
            i.Property(i => i.GroupNumber).HasMaxLength(20);
        });

        // BillingProvider (owned entity)
        entity.OwnsOne(c => c.BillingProvider, bp =>
        {
            bp.Property(bp => bp.Name).HasMaxLength(100).IsRequired();
            bp.Property(bp => bp.FederalTaxId).HasMaxLength(20).IsRequired();
            bp.OwnsOne(bp => bp.Address, a =>
            {
                a.ToTable("Medical_Claim_BillingProviderAddress"); // Separate table for BillingProvider Address
                a.Property(a => a.Street).HasMaxLength(100);
                a.Property(a => a.City).HasMaxLength(50);
                a.Property(a => a.State).HasMaxLength(2);
                a.Property(a => a.ZipCode).HasMaxLength(10);
                a.Property(a => a.Phone).HasMaxLength(20);
            });
            bp.Property(bp => bp.NpiNumber).HasMaxLength(20);
            bp.Property(bp => bp.Phone).HasMaxLength(20);
        });

        // ServiceFacility (owned entity)
        entity.OwnsOne(c => c.ServiceFacility, sf =>
        {
            sf.Property(sf => sf.Name).HasMaxLength(100).IsRequired();
            sf.Property(sf => sf.FederalTaxId).HasMaxLength(20).IsRequired();
            sf.OwnsOne(sf => sf.Address, a =>
            {
                a.ToTable("Medical_Claim_ServiceFacilityAddress"); // Separate table for ServiceFacility Address
                a.Property(a => a.Street).HasMaxLength(100);
                a.Property(a => a.City).HasMaxLength(50);
                a.Property(a => a.State).HasMaxLength(2);
                a.Property(a => a.ZipCode).HasMaxLength(10);
                a.Property(a => a.Phone).HasMaxLength(20);
            });
            sf.Property(sf => sf.NpiNumber).HasMaxLength(20);
            sf.Property(sf => sf.Phone).HasMaxLength(20);
        });
    }

    private void ConfigureClaimRelationships(EntityTypeBuilder<Claim> entity)
    {
        // Diagnosis Codes relationship
        entity.HasMany(c => c.DiagnosisCodes)
              .WithOne(dc => dc.Claim)
              .HasForeignKey(dc => dc.ClaimId)
              .OnDelete(DeleteBehavior.Cascade); // Allow cascading delete of DiagnosisCodes

        // Service Lines relationship
        entity.HasMany(c => c.ServiceLines)
              .WithOne(sl => sl.Claim)
              .HasForeignKey(sl => sl.ClaimId)
              .OnDelete(DeleteBehavior.Cascade); // Allow cascading delete of ServiceLines
    }
}

```

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

#### Property: `Albums`

```csharp
// Music Entities
public DbSet<Album> Albums { get; set; }

```

#### Property: `CDs`

```csharp
public DbSet<CD> CDs { get; set; }

```

#### Property: `Tracks`

```csharp
public DbSet<Track> Tracks { get; set; }

```

#### Property: `TaskItems`

```csharp

// Management Entities
public DbSet<TaskItem> TaskItems { get; set; }

```

#### Property: `Claims`

```csharp

// Medical Entities
public DbSet<Claim> Claims { get; set; }

```

#### Property: `Addresses`

```csharp
public DbSet<Address> Addresses { get; set; }

```

#### Property: `DiagnosisCodes`

```csharp
public DbSet<DiagnosisCode> DiagnosisCodes { get; set; }

```

#### Property: `ServiceLines`

```csharp
public DbSet<ServiceLine> ServiceLines { get; set; }

```

### Methods

| Name | Signature |
|------|-----------|
| `OnConfiguring` | `protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)` |
| `OnModelCreating` | `protected void OnModelCreating(ModelBuilder modelBuilder)` |
| `ConfigureMusicEntities` | `void ConfigureMusicEntities(ModelBuilder modelBuilder)` |
| `ConfigureMedicalEntities` | `void ConfigureMedicalEntities(ModelBuilder modelBuilder)` |
| `ConfigureClaimEntity` | `void ConfigureClaimEntity(EntityTypeBuilder<Claim> entity)` |
| `ConfigureOwnedProperties` | `void ConfigureOwnedProperties(EntityTypeBuilder<Claim> entity)` |
| `ConfigureClaimRelationships` | `void ConfigureClaimRelationships(EntityTypeBuilder<Claim> entity)` |

#### Method: `OnConfiguring`

```csharp

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        optionsBuilder.UseSqlServer("DefaultConnection", options =>
            options.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null));
    }
}

```

#### Method: `OnModelCreating`

```csharp

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    ConfigureMusicEntities(modelBuilder);
    ConfigureMedicalEntities(modelBuilder);
}

```

#### Method: `ConfigureMusicEntities`

```csharp

private void ConfigureMusicEntities(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Album>()
        .HasMany(a => a.CDs)
        .WithOne(c => c.Album)
        .HasForeignKey(c => c.AlbumId)
        .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<CD>()
        .HasMany(c => c.Tracks)
        .WithOne(t => t.CD)
        .HasForeignKey(t => t.CDId)
        .OnDelete(DeleteBehavior.Restrict);
}

```

#### Method: `ConfigureMedicalEntities`

```csharp

private void ConfigureMedicalEntities(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Claim>(entity =>
    {
        ConfigureClaimEntity(entity);
    });
}

```

#### Method: `ConfigureClaimEntity`

```csharp

private void ConfigureClaimEntity(EntityTypeBuilder<Claim> entity)
{
    // Configure complex properties
    ConfigureOwnedProperties(entity);

    // Configure relationships
    ConfigureClaimRelationships(entity);
}

```

#### Method: `ConfigureOwnedProperties`

```csharp

private void ConfigureOwnedProperties(EntityTypeBuilder<Claim> entity)
{
    // OtherInsurance (owned entity)
    entity.OwnsOne(c => c.OtherInsurance, oi =>
    {
        oi.Property(oi => oi.PolicyHolderName).HasMaxLength(50);
        oi.Property(oi => oi.PolicyNumber).HasMaxLength(20);
        oi.Property(oi => oi.PlanName).HasMaxLength(50);
    });

    // ConditionRelated (owned entity)
    entity.OwnsOne(c => c.ConditionRelated, cr =>
    {
        cr.Property(cr => cr.Employment);
        cr.Property(cr => cr.AutoAccident);
        cr.Property(cr => cr.OtherAccident);
        cr.Property(cr => cr.AccidentState).HasMaxLength(2);
    });

    // Patient (owned entity)
    entity.OwnsOne(c => c.Patient, p =>
    {
        p.Property(p => p.LastName).HasMaxLength(50).IsRequired();
        p.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
        p.Property(p => p.BirthDate).IsRequired();
        p.Property(p => p.Sex).IsRequired();
        p.OwnsOne(p => p.Address, a =>
        {
            a.ToTable("Medical_Claim_PatientAddress"); // Separate table for Patient Address
            a.Property(a => a.Street).HasMaxLength(100);
            a.Property(a => a.City).HasMaxLength(50);
            a.Property(a => a.State).HasMaxLength(2);
            a.Property(a => a.ZipCode).HasMaxLength(10);
            a.Property(a => a.Phone).HasMaxLength(20);
        });
    });

    // Insured (owned entity)
    entity.OwnsOne(c => c.Insured, i =>
    {
        i.Property(i => i.LastName).HasMaxLength(50).IsRequired();
        i.Property(i => i.FirstName).HasMaxLength(50).IsRequired();
        i.OwnsOne(i => i.Address, a =>
        {
            a.ToTable("Medical_Claim_InsuredAddress"); // Separate table for Insured Address
            a.Property(a => a.Street).HasMaxLength(100);
            a.Property(a => a.City).HasMaxLength(50);
            a.Property(a => a.State).HasMaxLength(2);
            a.Property(a => a.ZipCode).HasMaxLength(10);
            a.Property(a => a.Phone).HasMaxLength(20);
        });
        i.Property(i => i.GroupNumber).HasMaxLength(20);
    });

    // BillingProvider (owned entity)
    entity.OwnsOne(c => c.BillingProvider, bp =>
    {
        bp.Property(bp => bp.Name).HasMaxLength(100).IsRequired();
        bp.Property(bp => bp.FederalTaxId).HasMaxLength(20).IsRequired();
        bp.OwnsOne(bp => bp.Address, a =>
        {
            a.ToTable("Medical_Claim_BillingProviderAddress"); // Separate table for BillingProvider Address
            a.Property(a => a.Street).HasMaxLength(100);
            a.Property(a => a.City).HasMaxLength(50);
            a.Property(a => a.State).HasMaxLength(2);
            a.Property(a => a.ZipCode).HasMaxLength(10);
            a.Property(a => a.Phone).HasMaxLength(20);
        });
        bp.Property(bp => bp.NpiNumber).HasMaxLength(20);
        bp.Property(bp => bp.Phone).HasMaxLength(20);
    });

    // ServiceFacility (owned entity)
    entity.OwnsOne(c => c.ServiceFacility, sf =>
    {
        sf.Property(sf => sf.Name).HasMaxLength(100).IsRequired();
        sf.Property(sf => sf.FederalTaxId).HasMaxLength(20).IsRequired();
        sf.OwnsOne(sf => sf.Address, a =>
        {
            a.ToTable("Medical_Claim_ServiceFacilityAddress"); // Separate table for ServiceFacility Address
            a.Property(a => a.Street).HasMaxLength(100);
            a.Property(a => a.City).HasMaxLength(50);
            a.Property(a => a.State).HasMaxLength(2);
            a.Property(a => a.ZipCode).HasMaxLength(10);
            a.Property(a => a.Phone).HasMaxLength(20);
        });
        sf.Property(sf => sf.NpiNumber).HasMaxLength(20);
        sf.Property(sf => sf.Phone).HasMaxLength(20);
    });
}

```

#### Method: `ConfigureClaimRelationships`

```csharp

private void ConfigureClaimRelationships(EntityTypeBuilder<Claim> entity)
{
    // Diagnosis Codes relationship
    entity.HasMany(c => c.DiagnosisCodes)
          .WithOne(dc => dc.Claim)
          .HasForeignKey(dc => dc.ClaimId)
          .OnDelete(DeleteBehavior.Cascade); // Allow cascading delete of DiagnosisCodes

    // Service Lines relationship
    entity.HasMany(c => c.ServiceLines)
          .WithOne(sl => sl.Claim)
          .HasForeignKey(sl => sl.ClaimId)
          .OnDelete(DeleteBehavior.Cascade); // Allow cascading delete of ServiceLines
}

```

