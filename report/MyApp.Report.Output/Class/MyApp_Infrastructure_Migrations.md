# Namespace: `MyApp.Infrastructure.Migrations`

## Class: `AppDbContextModelSnapshot`

- **File Path:** `MyApp.Infrastructure/Migrations/AppDbContextModelSnapshot.cs`
- **Inherits From:** `ModelSnapshot`

### Class Code

```csharp
[DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApp.Domain.Entities.Management.TaskItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int?>("TaskObjectId")
                        .HasColumnType("int");

                    b.Property<int>("TaskObjectType")
                        .HasColumnType("int");

                    b.Property<int>("TaskSubType")
                        .HasColumnType("int");

                    b.Property<int>("TaskType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Management_TaskItem");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.Property<int>("FormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormId"));

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InsuranceProgram")
                        .HasColumnType("int");

                    b.Property<string>("InsuredIdNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("PatientSignatureDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PhysicianSignatureDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalCharge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FormId");

                    b.ToTable("Medical_Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("ClaimId");

                    b.ToTable("Medical_Claim_Diagnosis");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =>
                {
                    b.Property<int>("ServiceLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceLineId"));

                    b.Property<decimal>("Charge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<string>("DiagnosisPointer")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Modifier")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ProcedureCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RenderingProviderId")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("ServiceEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ServiceStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ServiceLineId");

                    b.HasIndex("ClaimId");

                    b.ToTable("Medical_Claim_ServiceLine");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.ToTable("Music_Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("AlbumId");

                    b.ToTable("Music_CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CDId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("CDId");

                    b.ToTable("Music_Track");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "BillingProvider", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FederalTaxId")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("NpiNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Phone")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_BillingProviderAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "ServiceFacility", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FederalTaxId")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("NpiNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Phone")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_ServiceFacilityAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.ConditionRelated", "ConditionRelated", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("AccidentState")
                                .HasMaxLength(2)
                                .HasColumnType("nvarchar(2)");

                            b1.Property<bool>("AutoAccident")
                                .HasColumnType("bit");

                            b1.Property<bool>("Employment")
                                .HasColumnType("bit");

                            b1.Property<bool>("OtherAccident")
                                .HasColumnType("bit");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.InsuredInfo", "Insured", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("GroupNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_InsuredAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.OtherInsuranceInfo", "OtherInsurance", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedDate")
                                .HasColumnType("datetime2");

                            b1.Property<string>("PlanName")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("PolicyHolderName")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("PolicyNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.PatientInfo", "Patient", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("BirthDate")
                                .HasColumnType("datetime2");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<int>("RelationshipToInsured")
                                .HasColumnType("int");

                            b1.Property<int>("Sex")
                                .HasColumnType("int");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_PatientAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.Navigation("BillingProvider")
                        .IsRequired();

                    b.Navigation("ConditionRelated")
                        .IsRequired();

                    b.Navigation("Insured")
                        .IsRequired();

                    b.Navigation("OtherInsurance");

                    b.Navigation("Patient")
                        .IsRequired();

                    b.Navigation("ServiceFacility")
                        .IsRequired();
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")
                        .WithMany("DiagnosisCodes")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")
                        .WithMany("ServiceLines")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")
                        .WithMany("CDs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")
                        .WithMany("Tracks")
                        .HasForeignKey("CDId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.Navigation("DiagnosisCodes");

                    b.Navigation("ServiceLines");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Navigation("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `BuildModel` | `protected void BuildModel(ModelBuilder modelBuilder)` |

#### Method: `BuildModel`

```csharp
protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApp.Domain.Entities.Management.TaskItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int?>("TaskObjectId")
                        .HasColumnType("int");

                    b.Property<int>("TaskObjectType")
                        .HasColumnType("int");

                    b.Property<int>("TaskSubType")
                        .HasColumnType("int");

                    b.Property<int>("TaskType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Management_TaskItem");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.Property<int>("FormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormId"));

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InsuranceProgram")
                        .HasColumnType("int");

                    b.Property<string>("InsuredIdNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("PatientSignatureDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PhysicianSignatureDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalCharge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FormId");

                    b.ToTable("Medical_Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("ClaimId");

                    b.ToTable("Medical_Claim_Diagnosis");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =>
                {
                    b.Property<int>("ServiceLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceLineId"));

                    b.Property<decimal>("Charge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<string>("DiagnosisPointer")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Modifier")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ProcedureCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RenderingProviderId")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("ServiceEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ServiceStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ServiceLineId");

                    b.HasIndex("ClaimId");

                    b.ToTable("Medical_Claim_ServiceLine");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.ToTable("Music_Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("AlbumId");

                    b.ToTable("Music_CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CDId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("CDId");

                    b.ToTable("Music_Track");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "BillingProvider", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FederalTaxId")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("NpiNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Phone")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_BillingProviderAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "ServiceFacility", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FederalTaxId")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("NpiNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Phone")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_ServiceFacilityAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.ConditionRelated", "ConditionRelated", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("AccidentState")
                                .HasMaxLength(2)
                                .HasColumnType("nvarchar(2)");

                            b1.Property<bool>("AutoAccident")
                                .HasColumnType("bit");

                            b1.Property<bool>("Employment")
                                .HasColumnType("bit");

                            b1.Property<bool>("OtherAccident")
                                .HasColumnType("bit");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.InsuredInfo", "Insured", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("GroupNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_InsuredAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.OtherInsuranceInfo", "OtherInsurance", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedDate")
                                .HasColumnType("datetime2");

                            b1.Property<string>("PlanName")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("PolicyHolderName")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("PolicyNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.PatientInfo", "Patient", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("BirthDate")
                                .HasColumnType("datetime2");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<int>("RelationshipToInsured")
                                .HasColumnType("int");

                            b1.Property<int>("Sex")
                                .HasColumnType("int");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_PatientAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.Navigation("BillingProvider")
                        .IsRequired();

                    b.Navigation("ConditionRelated")
                        .IsRequired();

                    b.Navigation("Insured")
                        .IsRequired();

                    b.Navigation("OtherInsurance");

                    b.Navigation("Patient")
                        .IsRequired();

                    b.Navigation("ServiceFacility")
                        .IsRequired();
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")
                        .WithMany("DiagnosisCodes")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")
                        .WithMany("ServiceLines")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")
                        .WithMany("CDs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")
                        .WithMany("Tracks")
                        .HasForeignKey("CDId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.Navigation("DiagnosisCodes");

                    b.Navigation("ServiceLines");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Navigation("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
```

## Class: `InitialCreate`

- **File Path:** `MyApp.Infrastructure/Migrations/20250129035002_InitialCreate.cs`
- **Inherits From:** `Migration`

### Class Code

```csharp
/// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CDs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<TimeSpan>(type: "time", nullable: false),
                    CDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_CDs_CDId",
                        column: x => x.CDId,
                        principalTable: "CDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CDs_AlbumId",
                table: "CDs",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_CDId",
                table: "Tracks",
                column: "CDId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "CDs");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `Up` | `protected void Up(MigrationBuilder migrationBuilder)` |
| `Down` | `protected void Down(MigrationBuilder migrationBuilder)` |

#### Method: `Up`

```csharp
/// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CDs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<TimeSpan>(type: "time", nullable: false),
                    CDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_CDs_CDId",
                        column: x => x.CDId,
                        principalTable: "CDs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CDs_AlbumId",
                table: "CDs",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_CDId",
                table: "Tracks",
                column: "CDId");
        }
```

#### Method: `Down`

```csharp
/// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "CDs");

            migrationBuilder.DropTable(
                name: "Albums");
        }
```

## Class: `InitialCreate`

- **File Path:** `MyApp.Infrastructure/Migrations/20250129035002_InitialCreate.Designer.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[DbContext(typeof(AppDbContext))]
    [Migration("20250129035002_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CDId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CDId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")
                        .WithMany("CDs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")
                        .WithMany("Tracks")
                        .HasForeignKey("CDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Navigation("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `BuildTargetModel` | `protected void BuildTargetModel(ModelBuilder modelBuilder)` |

#### Method: `BuildTargetModel`

```csharp
/// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CDId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CDId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")
                        .WithMany("CDs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")
                        .WithMany("Tracks")
                        .HasForeignKey("CDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Navigation("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
```

## Class: `NewClaims`

- **File Path:** `MyApp.Infrastructure/Migrations/20250131064954_NewClaims.cs`
- **Inherits From:** `Migration`

### Class Code

```csharp
/// <inheritdoc />
    public partial class NewClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track");

            migrationBuilder.CreateTable(
                name: "Medical_Claim",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceProgram = table.Column<int>(type: "int", nullable: false),
                    InsuredIdNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Patient_LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Patient_FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Patient_BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Patient_Sex = table.Column<int>(type: "int", nullable: false),
                    Patient_RelationshipToInsured = table.Column<int>(type: "int", nullable: false),
                    Insured_LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Insured_FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Insured_GroupNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OtherInsurance_PolicyHolderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OtherInsurance_PolicyNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OtherInsurance_PlanName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OtherInsurance_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConditionRelated_Employment = table.Column<bool>(type: "bit", nullable: false),
                    ConditionRelated_AutoAccident = table.Column<bool>(type: "bit", nullable: false),
                    ConditionRelated_OtherAccident = table.Column<bool>(type: "bit", nullable: false),
                    ConditionRelated_AccidentState = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    BillingProvider_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BillingProvider_FederalTaxId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BillingProvider_NpiNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BillingProvider_Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ServiceFacility_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ServiceFacility_FederalTaxId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ServiceFacility_NpiNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ServiceFacility_Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TotalCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PatientSignatureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhysicianSignatureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim", x => x.FormId);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_BillingProviderAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_BillingProviderAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_BillingProviderAddress_Medical_Claim_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_Diagnosis",
                columns: table => new
                {
                    DiagnosisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_Diagnosis", x => x.DiagnosisId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_Diagnosis_Medical_Claim_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_InsuredAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_InsuredAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_InsuredAddress_Medical_Claim_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_PatientAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_PatientAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_PatientAddress_Medical_Claim_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_ServiceFacilityAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_ServiceFacilityAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_ServiceFacilityAddress_Medical_Claim_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_ServiceLine",
                columns: table => new
                {
                    ServiceLineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcedureCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Modifier = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    DiagnosisPointer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Charge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RenderingProviderId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_ServiceLine", x => x.ServiceLineId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_ServiceLine_Medical_Claim_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Claim_Diagnosis_ClaimId",
                table: "Medical_Claim_Diagnosis",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Claim_ServiceLine_ClaimId",
                table: "Medical_Claim_ServiceLine",
                column: "ClaimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD",
                column: "AlbumId",
                principalTable: "Music_Album",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track",
                column: "CDId",
                principalTable: "Music_CD",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track");

            migrationBuilder.DropTable(
                name: "Medical_Claim_BillingProviderAddress");

            migrationBuilder.DropTable(
                name: "Medical_Claim_Diagnosis");

            migrationBuilder.DropTable(
                name: "Medical_Claim_InsuredAddress");

            migrationBuilder.DropTable(
                name: "Medical_Claim_PatientAddress");

            migrationBuilder.DropTable(
                name: "Medical_Claim_ServiceFacilityAddress");

            migrationBuilder.DropTable(
                name: "Medical_Claim_ServiceLine");

            migrationBuilder.DropTable(
                name: "Medical_Claim");

            migrationBuilder.AddForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD",
                column: "AlbumId",
                principalTable: "Music_Album",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track",
                column: "CDId",
                principalTable: "Music_CD",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `Up` | `protected void Up(MigrationBuilder migrationBuilder)` |
| `Down` | `protected void Down(MigrationBuilder migrationBuilder)` |

#### Method: `Up`

```csharp
/// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track");

            migrationBuilder.CreateTable(
                name: "Medical_Claim",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceProgram = table.Column<int>(type: "int", nullable: false),
                    InsuredIdNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Patient_LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Patient_FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Patient_BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Patient_Sex = table.Column<int>(type: "int", nullable: false),
                    Patient_RelationshipToInsured = table.Column<int>(type: "int", nullable: false),
                    Insured_LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Insured_FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Insured_GroupNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OtherInsurance_PolicyHolderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OtherInsurance_PolicyNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OtherInsurance_PlanName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OtherInsurance_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConditionRelated_Employment = table.Column<bool>(type: "bit", nullable: false),
                    ConditionRelated_AutoAccident = table.Column<bool>(type: "bit", nullable: false),
                    ConditionRelated_OtherAccident = table.Column<bool>(type: "bit", nullable: false),
                    ConditionRelated_AccidentState = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    BillingProvider_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BillingProvider_FederalTaxId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BillingProvider_NpiNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BillingProvider_Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ServiceFacility_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ServiceFacility_FederalTaxId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ServiceFacility_NpiNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ServiceFacility_Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TotalCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PatientSignatureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhysicianSignatureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim", x => x.FormId);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_BillingProviderAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_BillingProviderAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_BillingProviderAddress_Medical_Claim_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_Diagnosis",
                columns: table => new
                {
                    DiagnosisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_Diagnosis", x => x.DiagnosisId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_Diagnosis_Medical_Claim_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_InsuredAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_InsuredAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_InsuredAddress_Medical_Claim_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_PatientAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_PatientAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_PatientAddress_Medical_Claim_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_ServiceFacilityAddress",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_ServiceFacilityAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_ServiceFacilityAddress_Medical_Claim_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim_ServiceLine",
                columns: table => new
                {
                    ServiceLineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcedureCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Modifier = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    DiagnosisPointer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Charge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RenderingProviderId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_ServiceLine", x => x.ServiceLineId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_ServiceLine_Medical_Claim_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Medical_Claim",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Claim_Diagnosis_ClaimId",
                table: "Medical_Claim_Diagnosis",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Claim_ServiceLine_ClaimId",
                table: "Medical_Claim_ServiceLine",
                column: "ClaimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD",
                column: "AlbumId",
                principalTable: "Music_Album",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track",
                column: "CDId",
                principalTable: "Music_CD",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
```

#### Method: `Down`

```csharp
/// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track");

            migrationBuilder.DropTable(
                name: "Medical_Claim_BillingProviderAddress");

            migrationBuilder.DropTable(
                name: "Medical_Claim_Diagnosis");

            migrationBuilder.DropTable(
                name: "Medical_Claim_InsuredAddress");

            migrationBuilder.DropTable(
                name: "Medical_Claim_PatientAddress");

            migrationBuilder.DropTable(
                name: "Medical_Claim_ServiceFacilityAddress");

            migrationBuilder.DropTable(
                name: "Medical_Claim_ServiceLine");

            migrationBuilder.DropTable(
                name: "Medical_Claim");

            migrationBuilder.AddForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD",
                column: "AlbumId",
                principalTable: "Music_Album",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track",
                column: "CDId",
                principalTable: "Music_CD",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
```

## Class: `NewClaims`

- **File Path:** `MyApp.Infrastructure/Migrations/20250131064954_NewClaims.Designer.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[DbContext(typeof(AppDbContext))]
    [Migration("20250131064954_NewClaims")]
    partial class NewClaims
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApp.Domain.Entities.Management.TaskItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int?>("TaskObjectId")
                        .HasColumnType("int");

                    b.Property<int>("TaskObjectType")
                        .HasColumnType("int");

                    b.Property<int>("TaskSubType")
                        .HasColumnType("int");

                    b.Property<int>("TaskType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Management_TaskItem");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.Property<int>("FormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormId"));

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InsuranceProgram")
                        .HasColumnType("int");

                    b.Property<string>("InsuredIdNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("PatientSignatureDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PhysicianSignatureDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalCharge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FormId");

                    b.ToTable("Medical_Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("ClaimId");

                    b.ToTable("Medical_Claim_Diagnosis");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =>
                {
                    b.Property<int>("ServiceLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceLineId"));

                    b.Property<decimal>("Charge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<string>("DiagnosisPointer")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Modifier")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ProcedureCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RenderingProviderId")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("ServiceEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ServiceStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ServiceLineId");

                    b.HasIndex("ClaimId");

                    b.ToTable("Medical_Claim_ServiceLine");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.ToTable("Music_Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("AlbumId");

                    b.ToTable("Music_CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CDId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("CDId");

                    b.ToTable("Music_Track");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "BillingProvider", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FederalTaxId")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("NpiNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Phone")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_BillingProviderAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "ServiceFacility", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FederalTaxId")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("NpiNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Phone")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_ServiceFacilityAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.ConditionRelated", "ConditionRelated", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("AccidentState")
                                .HasMaxLength(2)
                                .HasColumnType("nvarchar(2)");

                            b1.Property<bool>("AutoAccident")
                                .HasColumnType("bit");

                            b1.Property<bool>("Employment")
                                .HasColumnType("bit");

                            b1.Property<bool>("OtherAccident")
                                .HasColumnType("bit");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.InsuredInfo", "Insured", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("GroupNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_InsuredAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.OtherInsuranceInfo", "OtherInsurance", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedDate")
                                .HasColumnType("datetime2");

                            b1.Property<string>("PlanName")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("PolicyHolderName")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("PolicyNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.PatientInfo", "Patient", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("BirthDate")
                                .HasColumnType("datetime2");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<int>("RelationshipToInsured")
                                .HasColumnType("int");

                            b1.Property<int>("Sex")
                                .HasColumnType("int");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_PatientAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.Navigation("BillingProvider")
                        .IsRequired();

                    b.Navigation("ConditionRelated")
                        .IsRequired();

                    b.Navigation("Insured")
                        .IsRequired();

                    b.Navigation("OtherInsurance");

                    b.Navigation("Patient")
                        .IsRequired();

                    b.Navigation("ServiceFacility")
                        .IsRequired();
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")
                        .WithMany("DiagnosisCodes")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")
                        .WithMany("ServiceLines")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")
                        .WithMany("CDs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")
                        .WithMany("Tracks")
                        .HasForeignKey("CDId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.Navigation("DiagnosisCodes");

                    b.Navigation("ServiceLines");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Navigation("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `BuildTargetModel` | `protected void BuildTargetModel(ModelBuilder modelBuilder)` |

#### Method: `BuildTargetModel`

```csharp
/// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApp.Domain.Entities.Management.TaskItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int?>("TaskObjectId")
                        .HasColumnType("int");

                    b.Property<int>("TaskObjectType")
                        .HasColumnType("int");

                    b.Property<int>("TaskSubType")
                        .HasColumnType("int");

                    b.Property<int>("TaskType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Management_TaskItem");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.Property<int>("FormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormId"));

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InsuranceProgram")
                        .HasColumnType("int");

                    b.Property<string>("InsuredIdNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("PatientSignatureDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PhysicianSignatureDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalCharge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FormId");

                    b.ToTable("Medical_Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("ClaimId");

                    b.ToTable("Medical_Claim_Diagnosis");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =>
                {
                    b.Property<int>("ServiceLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceLineId"));

                    b.Property<decimal>("Charge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<string>("DiagnosisPointer")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Modifier")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ProcedureCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RenderingProviderId")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("ServiceEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ServiceStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ServiceLineId");

                    b.HasIndex("ClaimId");

                    b.ToTable("Medical_Claim_ServiceLine");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.ToTable("Music_Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("AlbumId");

                    b.ToTable("Music_CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CDId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("CDId");

                    b.ToTable("Music_Track");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "BillingProvider", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FederalTaxId")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("NpiNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Phone")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_BillingProviderAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "ServiceFacility", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FederalTaxId")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("NpiNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Phone")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_ServiceFacilityAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.ConditionRelated", "ConditionRelated", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("AccidentState")
                                .HasMaxLength(2)
                                .HasColumnType("nvarchar(2)");

                            b1.Property<bool>("AutoAccident")
                                .HasColumnType("bit");

                            b1.Property<bool>("Employment")
                                .HasColumnType("bit");

                            b1.Property<bool>("OtherAccident")
                                .HasColumnType("bit");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.InsuredInfo", "Insured", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("GroupNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_InsuredAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.OtherInsuranceInfo", "OtherInsurance", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedDate")
                                .HasColumnType("datetime2");

                            b1.Property<string>("PlanName")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("PolicyHolderName")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("PolicyNumber")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");
                        });

                    b.OwnsOne("MyApp.Domain.Entities.Medical.PatientInfo", "Patient", b1 =>
                        {
                            b1.Property<int>("ClaimFormId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("BirthDate")
                                .HasColumnType("datetime2");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<int>("RelationshipToInsured")
                                .HasColumnType("int");

                            b1.Property<int>("Sex")
                                .HasColumnType("int");

                            b1.HasKey("ClaimFormId");

                            b1.ToTable("Medical_Claim");

                            b1.WithOwner()
                                .HasForeignKey("ClaimFormId");

                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =>
                                {
                                    b2.Property<int>("AddressId")
                                        .HasColumnType("int");

                                    b2.Property<string>("City")
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Phone")
                                        .HasMaxLength(20)
                                        .HasColumnType("nvarchar(20)");

                                    b2.Property<string>("State")
                                        .HasMaxLength(2)
                                        .HasColumnType("nvarchar(2)");

                                    b2.Property<string>("Street")
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.Property<string>("ZipCode")
                                        .HasMaxLength(10)
                                        .HasColumnType("nvarchar(10)");

                                    b2.HasKey("AddressId");

                                    b2.ToTable("Medical_Claim_PatientAddress", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AddressId");
                                });

                            b1.Navigation("Address")
                                .IsRequired();
                        });

                    b.Navigation("BillingProvider")
                        .IsRequired();

                    b.Navigation("ConditionRelated")
                        .IsRequired();

                    b.Navigation("Insured")
                        .IsRequired();

                    b.Navigation("OtherInsurance");

                    b.Navigation("Patient")
                        .IsRequired();

                    b.Navigation("ServiceFacility")
                        .IsRequired();
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")
                        .WithMany("DiagnosisCodes")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")
                        .WithMany("ServiceLines")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")
                        .WithMany("CDs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")
                        .WithMany("Tracks")
                        .HasForeignKey("CDId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =>
                {
                    b.Navigation("DiagnosisCodes");

                    b.Navigation("ServiceLines");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Navigation("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
```

## Class: `NewTaskItem`

- **File Path:** `MyApp.Infrastructure/Migrations/20250130054003_NewTaskItem.cs`
- **Inherits From:** `Migration`

### Class Code

```csharp
/// <inheritdoc />
    public partial class NewTaskItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Management_TaskItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    TaskType = table.Column<int>(type: "int", nullable: false),
                    TaskSubType = table.Column<int>(type: "int", nullable: false),
                    TaskObjectType = table.Column<int>(type: "int", nullable: false),
                    TaskObjectId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Management_TaskItem", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Management_TaskItem");
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `Up` | `protected void Up(MigrationBuilder migrationBuilder)` |
| `Down` | `protected void Down(MigrationBuilder migrationBuilder)` |

#### Method: `Up`

```csharp
/// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Management_TaskItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    TaskType = table.Column<int>(type: "int", nullable: false),
                    TaskSubType = table.Column<int>(type: "int", nullable: false),
                    TaskObjectType = table.Column<int>(type: "int", nullable: false),
                    TaskObjectId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Management_TaskItem", x => x.ID);
                });
        }
```

#### Method: `Down`

```csharp
/// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Management_TaskItem");
        }
```

## Class: `NewTaskItem`

- **File Path:** `MyApp.Infrastructure/Migrations/20250130054003_NewTaskItem.Designer.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[DbContext(typeof(AppDbContext))]
    [Migration("20250130054003_NewTaskItem")]
    partial class NewTaskItem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApp.Domain.Entities.Management.TaskItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int?>("TaskObjectId")
                        .HasColumnType("int");

                    b.Property<int>("TaskObjectType")
                        .HasColumnType("int");

                    b.Property<int>("TaskSubType")
                        .HasColumnType("int");

                    b.Property<int>("TaskType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Management_TaskItem");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.ToTable("Music_Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("AlbumId");

                    b.ToTable("Music_CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CDId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("CDId");

                    b.ToTable("Music_Track");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")
                        .WithMany("CDs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")
                        .WithMany("Tracks")
                        .HasForeignKey("CDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Navigation("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `BuildTargetModel` | `protected void BuildTargetModel(ModelBuilder modelBuilder)` |

#### Method: `BuildTargetModel`

```csharp
/// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApp.Domain.Entities.Management.TaskItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int?>("TaskObjectId")
                        .HasColumnType("int");

                    b.Property<int>("TaskObjectType")
                        .HasColumnType("int");

                    b.Property<int>("TaskSubType")
                        .HasColumnType("int");

                    b.Property<int>("TaskType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Management_TaskItem");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.ToTable("Music_Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("AlbumId");

                    b.ToTable("Music_CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CDId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("CDId");

                    b.ToTable("Music_Track");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")
                        .WithMany("CDs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")
                        .WithMany("Tracks")
                        .HasForeignKey("CDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Navigation("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
```

## Class: `UpdatedDBStructure`

- **File Path:** `MyApp.Infrastructure/Migrations/20250130034035_UpdatedDBStructure.cs`
- **Inherits From:** `Migration`

### Class Code

```csharp
/// <inheritdoc />
    public partial class UpdatedDBStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CDs_Albums_AlbumId",
                table: "CDs");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_CDs_CDId",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CDs",
                table: "CDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Albums");

            migrationBuilder.RenameTable(
                name: "Tracks",
                newName: "Music_Track");

            migrationBuilder.RenameTable(
                name: "CDs",
                newName: "Music_CD");

            migrationBuilder.RenameTable(
                name: "Albums",
                newName: "Music_Album");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Music_Track",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_CDId",
                table: "Music_Track",
                newName: "IX_Music_Track_CDId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Music_CD",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_CDs_AlbumId",
                table: "Music_CD",
                newName: "IX_Music_CD_AlbumId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Music_Album",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Music_Track",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Music_CD",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Music_Album",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Music_Track",
                table: "Music_Track",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Music_CD",
                table: "Music_CD",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Music_Album",
                table: "Music_Album",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD",
                column: "AlbumId",
                principalTable: "Music_Album",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track",
                column: "CDId",
                principalTable: "Music_CD",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Music_Track",
                table: "Music_Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Music_CD",
                table: "Music_CD");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Music_Album",
                table: "Music_Album");

            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Music_Album");

            migrationBuilder.RenameTable(
                name: "Music_Track",
                newName: "Tracks");

            migrationBuilder.RenameTable(
                name: "Music_CD",
                newName: "CDs");

            migrationBuilder.RenameTable(
                name: "Music_Album",
                newName: "Albums");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tracks",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Music_Track_CDId",
                table: "Tracks",
                newName: "IX_Tracks_CDId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CDs",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Music_CD_AlbumId",
                table: "CDs",
                newName: "IX_CDs_AlbumId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Albums",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CDs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CDs",
                table: "CDs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CDs_Albums_AlbumId",
                table: "CDs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_CDs_CDId",
                table: "Tracks",
                column: "CDId",
                principalTable: "CDs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `Up` | `protected void Up(MigrationBuilder migrationBuilder)` |
| `Down` | `protected void Down(MigrationBuilder migrationBuilder)` |

#### Method: `Up`

```csharp
/// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CDs_Albums_AlbumId",
                table: "CDs");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_CDs_CDId",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CDs",
                table: "CDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Albums");

            migrationBuilder.RenameTable(
                name: "Tracks",
                newName: "Music_Track");

            migrationBuilder.RenameTable(
                name: "CDs",
                newName: "Music_CD");

            migrationBuilder.RenameTable(
                name: "Albums",
                newName: "Music_Album");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Music_Track",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_CDId",
                table: "Music_Track",
                newName: "IX_Music_Track_CDId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Music_CD",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_CDs_AlbumId",
                table: "Music_CD",
                newName: "IX_Music_CD_AlbumId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Music_Album",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Music_Track",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Music_CD",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Music_Album",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Music_Track",
                table: "Music_Track",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Music_CD",
                table: "Music_CD",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Music_Album",
                table: "Music_Album",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD",
                column: "AlbumId",
                principalTable: "Music_Album",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track",
                column: "CDId",
                principalTable: "Music_CD",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
```

#### Method: `Down`

```csharp
/// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Music_Track",
                table: "Music_Track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Music_CD",
                table: "Music_CD");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Music_Album",
                table: "Music_Album");

            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Music_Album");

            migrationBuilder.RenameTable(
                name: "Music_Track",
                newName: "Tracks");

            migrationBuilder.RenameTable(
                name: "Music_CD",
                newName: "CDs");

            migrationBuilder.RenameTable(
                name: "Music_Album",
                newName: "Albums");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tracks",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Music_Track_CDId",
                table: "Tracks",
                newName: "IX_Tracks_CDId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CDs",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Music_CD_AlbumId",
                table: "CDs",
                newName: "IX_CDs_AlbumId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Albums",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CDs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tracks",
                table: "Tracks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CDs",
                table: "CDs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CDs_Albums_AlbumId",
                table: "CDs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_CDs_CDId",
                table: "Tracks",
                column: "CDId",
                principalTable: "CDs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
```

## Class: `UpdatedDBStructure`

- **File Path:** `MyApp.Infrastructure/Migrations/20250130034035_UpdatedDBStructure.Designer.cs`
- **Inherits From:** N/A

### Class Code

```csharp
[DbContext(typeof(AppDbContext))]
    [Migration("20250130034035_UpdatedDBStructure")]
    partial class UpdatedDBStructure
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.ToTable("Music_Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("AlbumId");

                    b.ToTable("Music_CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CDId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("CDId");

                    b.ToTable("Music_Track");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")
                        .WithMany("CDs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")
                        .WithMany("Tracks")
                        .HasForeignKey("CDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Navigation("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
```

### Methods

| Name | Signature |
|------|-----------|
| `BuildTargetModel` | `protected void BuildTargetModel(ModelBuilder modelBuilder)` |

#### Method: `BuildTargetModel`

```csharp
/// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.ToTable("Music_Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("AlbumId");

                    b.ToTable("Music_CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CDId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ID");

                    b.HasIndex("CDId");

                    b.ToTable("Music_Track");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")
                        .WithMany("CDs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =>
                {
                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")
                        .WithMany("Tracks")
                        .HasForeignKey("CDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CD");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =>
                {
                    b.Navigation("CDs");
                });

            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
```

