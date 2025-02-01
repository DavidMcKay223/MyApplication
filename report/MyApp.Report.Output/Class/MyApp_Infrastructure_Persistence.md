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

| Name | Type | Definition |
|------|------|-------------|
| `Albums` | `DbSet<Album>` | `// Music Entities<br>        public DbSet<Album> Albums { get; set; }` |
| `CDs` | `DbSet<CD>` | `public DbSet<CD> CDs { get; set; }` |
| `Tracks` | `DbSet<Track>` | `public DbSet<Track> Tracks { get; set; }` |
| `TaskItems` | `DbSet<TaskItem>` | `// Management Entities<br>        public DbSet<TaskItem> TaskItems { get; set; }` |
| `Claims` | `DbSet<Claim>` | `// Medical Entities<br>        public DbSet<Claim> Claims { get; set; }` |
| `Addresses` | `DbSet<Address>` | `public DbSet<Address> Addresses { get; set; }` |
| `DiagnosisCodes` | `DbSet<DiagnosisCode>` | `public DbSet<DiagnosisCode> DiagnosisCodes { get; set; }` |
| `ServiceLines` | `DbSet<ServiceLine>` | `public DbSet<ServiceLine> ServiceLines { get; set; }` |

### Methods

| Name | Signature | Definition |
|------|-----------|-------------|
| `OnConfiguring` | `protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)` | `protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)<br>        {<br>            if (!optionsBuilder.IsConfigured)<br>            {<br>                optionsBuilder.UseSqlServer("DefaultConnection", options =><br>                    options.EnableRetryOnFailure(<br>                        maxRetryCount: 5,<br>                        maxRetryDelay: TimeSpan.FromSeconds(30),<br>                        errorNumbersToAdd: null));<br>            }<br>        }` |
| `OnModelCreating` | `protected void OnModelCreating(ModelBuilder modelBuilder)` | `protected override void OnModelCreating(ModelBuilder modelBuilder)<br>        {<br>            ConfigureMusicEntities(modelBuilder);<br>            ConfigureMedicalEntities(modelBuilder);<br>        }` |
| `ConfigureMusicEntities` | `void ConfigureMusicEntities(ModelBuilder modelBuilder)` | `private void ConfigureMusicEntities(ModelBuilder modelBuilder)<br>        {<br>            modelBuilder.Entity<Album>()<br>                .HasMany(a => a.CDs)<br>                .WithOne(c => c.Album)<br>                .HasForeignKey(c => c.AlbumId)<br>                .OnDelete(DeleteBehavior.Restrict);<br><br>            modelBuilder.Entity<CD>()<br>                .HasMany(c => c.Tracks)<br>                .WithOne(t => t.CD)<br>                .HasForeignKey(t => t.CDId)<br>                .OnDelete(DeleteBehavior.Restrict);<br>        }` |
| `ConfigureMedicalEntities` | `void ConfigureMedicalEntities(ModelBuilder modelBuilder)` | `private void ConfigureMedicalEntities(ModelBuilder modelBuilder)<br>        {<br>            modelBuilder.Entity<Claim>(entity =><br>            {<br>                ConfigureClaimEntity(entity);<br>            });<br>        }` |
| `ConfigureClaimEntity` | `void ConfigureClaimEntity(EntityTypeBuilder<Claim> entity)` | `private void ConfigureClaimEntity(EntityTypeBuilder<Claim> entity)<br>        {<br>            // Configure complex properties<br>            ConfigureOwnedProperties(entity);<br><br>            // Configure relationships<br>            ConfigureClaimRelationships(entity);<br>        }` |
| `ConfigureOwnedProperties` | `void ConfigureOwnedProperties(EntityTypeBuilder<Claim> entity)` | `private void ConfigureOwnedProperties(EntityTypeBuilder<Claim> entity)<br>        {<br>            // OtherInsurance (owned entity)<br>            entity.OwnsOne(c => c.OtherInsurance, oi =><br>            {<br>                oi.Property(oi => oi.PolicyHolderName).HasMaxLength(50);<br>                oi.Property(oi => oi.PolicyNumber).HasMaxLength(20);<br>                oi.Property(oi => oi.PlanName).HasMaxLength(50);<br>            });<br><br>            // ConditionRelated (owned entity)<br>            entity.OwnsOne(c => c.ConditionRelated, cr =><br>            {<br>                cr.Property(cr => cr.Employment);<br>                cr.Property(cr => cr.AutoAccident);<br>                cr.Property(cr => cr.OtherAccident);<br>                cr.Property(cr => cr.AccidentState).HasMaxLength(2);<br>            });<br><br>            // Patient (owned entity)<br>            entity.OwnsOne(c => c.Patient, p =><br>            {<br>                p.Property(p => p.LastName).HasMaxLength(50).IsRequired();<br>                p.Property(p => p.FirstName).HasMaxLength(50).IsRequired();<br>                p.Property(p => p.BirthDate).IsRequired();<br>                p.Property(p => p.Sex).IsRequired();<br>                p.OwnsOne(p => p.Address, a =><br>                {<br>                    a.ToTable("Medical_Claim_PatientAddress"); // Separate table for Patient Address<br>                    a.Property(a => a.Street).HasMaxLength(100);<br>                    a.Property(a => a.City).HasMaxLength(50);<br>                    a.Property(a => a.State).HasMaxLength(2);<br>                    a.Property(a => a.ZipCode).HasMaxLength(10);<br>                    a.Property(a => a.Phone).HasMaxLength(20);<br>                });<br>            });<br><br>            // Insured (owned entity)<br>            entity.OwnsOne(c => c.Insured, i =><br>            {<br>                i.Property(i => i.LastName).HasMaxLength(50).IsRequired();<br>                i.Property(i => i.FirstName).HasMaxLength(50).IsRequired();<br>                i.OwnsOne(i => i.Address, a =><br>                {<br>                    a.ToTable("Medical_Claim_InsuredAddress"); // Separate table for Insured Address<br>                    a.Property(a => a.Street).HasMaxLength(100);<br>                    a.Property(a => a.City).HasMaxLength(50);<br>                    a.Property(a => a.State).HasMaxLength(2);<br>                    a.Property(a => a.ZipCode).HasMaxLength(10);<br>                    a.Property(a => a.Phone).HasMaxLength(20);<br>                });<br>                i.Property(i => i.GroupNumber).HasMaxLength(20);<br>            });<br><br>            // BillingProvider (owned entity)<br>            entity.OwnsOne(c => c.BillingProvider, bp =><br>            {<br>                bp.Property(bp => bp.Name).HasMaxLength(100).IsRequired();<br>                bp.Property(bp => bp.FederalTaxId).HasMaxLength(20).IsRequired();<br>                bp.OwnsOne(bp => bp.Address, a =><br>                {<br>                    a.ToTable("Medical_Claim_BillingProviderAddress"); // Separate table for BillingProvider Address<br>                    a.Property(a => a.Street).HasMaxLength(100);<br>                    a.Property(a => a.City).HasMaxLength(50);<br>                    a.Property(a => a.State).HasMaxLength(2);<br>                    a.Property(a => a.ZipCode).HasMaxLength(10);<br>                    a.Property(a => a.Phone).HasMaxLength(20);<br>                });<br>                bp.Property(bp => bp.NpiNumber).HasMaxLength(20);<br>                bp.Property(bp => bp.Phone).HasMaxLength(20);<br>            });<br><br>            // ServiceFacility (owned entity)<br>            entity.OwnsOne(c => c.ServiceFacility, sf =><br>            {<br>                sf.Property(sf => sf.Name).HasMaxLength(100).IsRequired();<br>                sf.Property(sf => sf.FederalTaxId).HasMaxLength(20).IsRequired();<br>                sf.OwnsOne(sf => sf.Address, a =><br>                {<br>                    a.ToTable("Medical_Claim_ServiceFacilityAddress"); // Separate table for ServiceFacility Address<br>                    a.Property(a => a.Street).HasMaxLength(100);<br>                    a.Property(a => a.City).HasMaxLength(50);<br>                    a.Property(a => a.State).HasMaxLength(2);<br>                    a.Property(a => a.ZipCode).HasMaxLength(10);<br>                    a.Property(a => a.Phone).HasMaxLength(20);<br>                });<br>                sf.Property(sf => sf.NpiNumber).HasMaxLength(20);<br>                sf.Property(sf => sf.Phone).HasMaxLength(20);<br>            });<br>        }` |
| `ConfigureClaimRelationships` | `void ConfigureClaimRelationships(EntityTypeBuilder<Claim> entity)` | `private void ConfigureClaimRelationships(EntityTypeBuilder<Claim> entity)<br>        {<br>            // Diagnosis Codes relationship<br>            entity.HasMany(c => c.DiagnosisCodes)<br>                  .WithOne(dc => dc.Claim)<br>                  .HasForeignKey(dc => dc.ClaimId)<br>                  .OnDelete(DeleteBehavior.Cascade); // Allow cascading delete of DiagnosisCodes<br><br>            // Service Lines relationship<br>            entity.HasMany(c => c.ServiceLines)<br>                  .WithOne(sl => sl.Claim)<br>                  .HasForeignKey(sl => sl.ClaimId)<br>                  .OnDelete(DeleteBehavior.Cascade); // Allow cascading delete of ServiceLines<br>        }` |

