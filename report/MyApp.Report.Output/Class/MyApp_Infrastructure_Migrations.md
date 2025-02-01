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

| Name | Signature | Definition |
|------|-----------|-------------|
| `BuildModel` | `protected void BuildModel(ModelBuilder modelBuilder)` | `protected override void BuildModel(ModelBuilder modelBuilder)<br>        {<br>#pragma warning disable 612, 618<br>            modelBuilder<br>                .HasAnnotation("ProductVersion", "9.0.1")<br>                .HasAnnotation("Relational:MaxIdentifierLength", 128);<br><br>            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Management.TaskItem", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<DateTime>("CreatedDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.Property<string>("Description")<br>                        .IsRequired()<br>                        .HasMaxLength(5000)<br>                        .HasColumnType("nvarchar(max)");<br><br>                    b.Property<bool>("IsCompleted")<br>                        .HasColumnType("bit");<br><br>                    b.Property<int?>("TaskObjectId")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("TaskObjectType")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("TaskSubType")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("TaskType")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Title")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.Property<DateTime?>("UpdatedDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.HasKey("ID");<br><br>                    b.ToTable("Management_TaskItem");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =><br>                {<br>                    b.Property<int>("FormId")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormId"));<br><br>                    b.Property<decimal>("AmountPaid")<br>                        .HasColumnType("decimal(18,2)");<br><br>                    b.Property<DateTime>("CreatedDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.Property<int>("InsuranceProgram")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("InsuredIdNumber")<br>                        .HasMaxLength(20)<br>                        .HasColumnType("nvarchar(20)");<br><br>                    b.Property<DateTime>("PatientSignatureDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.Property<DateTime>("PhysicianSignatureDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.Property<decimal>("TotalCharge")<br>                        .HasColumnType("decimal(18,2)");<br><br>                    b.Property<DateTime?>("UpdatedDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.HasKey("FormId");<br><br>                    b.ToTable("Medical_Claim");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =><br>                {<br>                    b.Property<int>("DiagnosisId")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));<br><br>                    b.Property<int>("ClaimId")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Code")<br>                        .IsRequired()<br>                        .HasMaxLength(10)<br>                        .HasColumnType("nvarchar(10)");<br><br>                    b.Property<int>("Priority")<br>                        .HasColumnType("int");<br><br>                    b.HasKey("DiagnosisId");<br><br>                    b.HasIndex("ClaimId");<br><br>                    b.ToTable("Medical_Claim_Diagnosis");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =><br>                {<br>                    b.Property<int>("ServiceLineId")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceLineId"));<br><br>                    b.Property<decimal>("Charge")<br>                        .HasColumnType("decimal(18,2)");<br><br>                    b.Property<int>("ClaimId")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("DiagnosisPointer")<br>                        .HasMaxLength(10)<br>                        .HasColumnType("nvarchar(10)");<br><br>                    b.Property<string>("Modifier")<br>                        .HasMaxLength(2)<br>                        .HasColumnType("nvarchar(2)");<br><br>                    b.Property<string>("ProcedureCode")<br>                        .IsRequired()<br>                        .HasMaxLength(10)<br>                        .HasColumnType("nvarchar(10)");<br><br>                    b.Property<string>("RenderingProviderId")<br>                        .IsRequired()<br>                        .HasMaxLength(20)<br>                        .HasColumnType("nvarchar(20)");<br><br>                    b.Property<DateTime>("ServiceEndDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.Property<DateTime>("ServiceStartDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.HasKey("ServiceLineId");<br><br>                    b.HasIndex("ClaimId");<br><br>                    b.ToTable("Medical_Claim_ServiceLine");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<string>("ArtistName")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.ToTable("Music_Album");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<int>("AlbumId")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("Genre")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Name")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.HasIndex("AlbumId");<br><br>                    b.ToTable("Music_CD");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<int>("CDId")<br>                        .HasColumnType("int");<br><br>                    b.Property<TimeSpan>("Length")<br>                        .HasColumnType("time");<br><br>                    b.Property<int>("Number")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Title")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.HasIndex("CDId");<br><br>                    b.ToTable("Music_Track");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =><br>                {<br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "BillingProvider", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<string>("FederalTaxId")<br>                                .IsRequired()<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.Property<string>("Name")<br>                                .IsRequired()<br>                                .HasMaxLength(100)<br>                                .HasColumnType("nvarchar(100)");<br><br>                            b1.Property<string>("NpiNumber")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.Property<string>("Phone")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br><br>                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =><br>                                {<br>                                    b2.Property<int>("AddressId")<br>                                        .HasColumnType("int");<br><br>                                    b2.Property<string>("City")<br>                                        .HasMaxLength(50)<br>                                        .HasColumnType("nvarchar(50)");<br><br>                                    b2.Property<string>("Phone")<br>                                        .HasMaxLength(20)<br>                                        .HasColumnType("nvarchar(20)");<br><br>                                    b2.Property<string>("State")<br>                                        .HasMaxLength(2)<br>                                        .HasColumnType("nvarchar(2)");<br><br>                                    b2.Property<string>("Street")<br>                                        .HasMaxLength(100)<br>                                        .HasColumnType("nvarchar(100)");<br><br>                                    b2.Property<string>("ZipCode")<br>                                        .HasMaxLength(10)<br>                                        .HasColumnType("nvarchar(10)");<br><br>                                    b2.HasKey("AddressId");<br><br>                                    b2.ToTable("Medical_Claim_BillingProviderAddress", (string)null);<br><br>                                    b2.WithOwner()<br>                                        .HasForeignKey("AddressId");<br>                                });<br><br>                            b1.Navigation("Address")<br>                                .IsRequired();<br>                        });<br><br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "ServiceFacility", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<string>("FederalTaxId")<br>                                .IsRequired()<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.Property<string>("Name")<br>                                .IsRequired()<br>                                .HasMaxLength(100)<br>                                .HasColumnType("nvarchar(100)");<br><br>                            b1.Property<string>("NpiNumber")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.Property<string>("Phone")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br><br>                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =><br>                                {<br>                                    b2.Property<int>("AddressId")<br>                                        .HasColumnType("int");<br><br>                                    b2.Property<string>("City")<br>                                        .HasMaxLength(50)<br>                                        .HasColumnType("nvarchar(50)");<br><br>                                    b2.Property<string>("Phone")<br>                                        .HasMaxLength(20)<br>                                        .HasColumnType("nvarchar(20)");<br><br>                                    b2.Property<string>("State")<br>                                        .HasMaxLength(2)<br>                                        .HasColumnType("nvarchar(2)");<br><br>                                    b2.Property<string>("Street")<br>                                        .HasMaxLength(100)<br>                                        .HasColumnType("nvarchar(100)");<br><br>                                    b2.Property<string>("ZipCode")<br>                                        .HasMaxLength(10)<br>                                        .HasColumnType("nvarchar(10)");<br><br>                                    b2.HasKey("AddressId");<br><br>                                    b2.ToTable("Medical_Claim_ServiceFacilityAddress", (string)null);<br><br>                                    b2.WithOwner()<br>                                        .HasForeignKey("AddressId");<br>                                });<br><br>                            b1.Navigation("Address")<br>                                .IsRequired();<br>                        });<br><br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.ConditionRelated", "ConditionRelated", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<string>("AccidentState")<br>                                .HasMaxLength(2)<br>                                .HasColumnType("nvarchar(2)");<br><br>                            b1.Property<bool>("AutoAccident")<br>                                .HasColumnType("bit");<br><br>                            b1.Property<bool>("Employment")<br>                                .HasColumnType("bit");<br><br>                            b1.Property<bool>("OtherAccident")<br>                                .HasColumnType("bit");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br>                        });<br><br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.InsuredInfo", "Insured", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<string>("FirstName")<br>                                .IsRequired()<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.Property<string>("GroupNumber")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.Property<string>("LastName")<br>                                .IsRequired()<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br><br>                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =><br>                                {<br>                                    b2.Property<int>("AddressId")<br>                                        .HasColumnType("int");<br><br>                                    b2.Property<string>("City")<br>                                        .HasMaxLength(50)<br>                                        .HasColumnType("nvarchar(50)");<br><br>                                    b2.Property<string>("Phone")<br>                                        .HasMaxLength(20)<br>                                        .HasColumnType("nvarchar(20)");<br><br>                                    b2.Property<string>("State")<br>                                        .HasMaxLength(2)<br>                                        .HasColumnType("nvarchar(2)");<br><br>                                    b2.Property<string>("Street")<br>                                        .HasMaxLength(100)<br>                                        .HasColumnType("nvarchar(100)");<br><br>                                    b2.Property<string>("ZipCode")<br>                                        .HasMaxLength(10)<br>                                        .HasColumnType("nvarchar(10)");<br><br>                                    b2.HasKey("AddressId");<br><br>                                    b2.ToTable("Medical_Claim_InsuredAddress", (string)null);<br><br>                                    b2.WithOwner()<br>                                        .HasForeignKey("AddressId");<br>                                });<br><br>                            b1.Navigation("Address")<br>                                .IsRequired();<br>                        });<br><br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.OtherInsuranceInfo", "OtherInsurance", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<DateTime>("CreatedDate")<br>                                .HasColumnType("datetime2");<br><br>                            b1.Property<string>("PlanName")<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.Property<string>("PolicyHolderName")<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.Property<string>("PolicyNumber")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br>                        });<br><br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.PatientInfo", "Patient", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<DateTime>("BirthDate")<br>                                .HasColumnType("datetime2");<br><br>                            b1.Property<string>("FirstName")<br>                                .IsRequired()<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.Property<string>("LastName")<br>                                .IsRequired()<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.Property<int>("RelationshipToInsured")<br>                                .HasColumnType("int");<br><br>                            b1.Property<int>("Sex")<br>                                .HasColumnType("int");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br><br>                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =><br>                                {<br>                                    b2.Property<int>("AddressId")<br>                                        .HasColumnType("int");<br><br>                                    b2.Property<string>("City")<br>                                        .HasMaxLength(50)<br>                                        .HasColumnType("nvarchar(50)");<br><br>                                    b2.Property<string>("Phone")<br>                                        .HasMaxLength(20)<br>                                        .HasColumnType("nvarchar(20)");<br><br>                                    b2.Property<string>("State")<br>                                        .HasMaxLength(2)<br>                                        .HasColumnType("nvarchar(2)");<br><br>                                    b2.Property<string>("Street")<br>                                        .HasMaxLength(100)<br>                                        .HasColumnType("nvarchar(100)");<br><br>                                    b2.Property<string>("ZipCode")<br>                                        .HasMaxLength(10)<br>                                        .HasColumnType("nvarchar(10)");<br><br>                                    b2.HasKey("AddressId");<br><br>                                    b2.ToTable("Medical_Claim_PatientAddress", (string)null);<br><br>                                    b2.WithOwner()<br>                                        .HasForeignKey("AddressId");<br>                                });<br><br>                            b1.Navigation("Address")<br>                                .IsRequired();<br>                        });<br><br>                    b.Navigation("BillingProvider")<br>                        .IsRequired();<br><br>                    b.Navigation("ConditionRelated")<br>                        .IsRequired();<br><br>                    b.Navigation("Insured")<br>                        .IsRequired();<br><br>                    b.Navigation("OtherInsurance");<br><br>                    b.Navigation("Patient")<br>                        .IsRequired();<br><br>                    b.Navigation("ServiceFacility")<br>                        .IsRequired();<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")<br>                        .WithMany("DiagnosisCodes")<br>                        .HasForeignKey("ClaimId")<br>                        .OnDelete(DeleteBehavior.Cascade)<br>                        .IsRequired();<br><br>                    b.Navigation("Claim");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")<br>                        .WithMany("ServiceLines")<br>                        .HasForeignKey("ClaimId")<br>                        .OnDelete(DeleteBehavior.Cascade)<br>                        .IsRequired();<br><br>                    b.Navigation("Claim");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")<br>                        .WithMany("CDs")<br>                        .HasForeignKey("AlbumId")<br>                        .OnDelete(DeleteBehavior.Restrict)<br>                        .IsRequired();<br><br>                    b.Navigation("Album");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")<br>                        .WithMany("Tracks")<br>                        .HasForeignKey("CDId")<br>                        .OnDelete(DeleteBehavior.Restrict)<br>                        .IsRequired();<br><br>                    b.Navigation("CD");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =><br>                {<br>                    b.Navigation("DiagnosisCodes");<br><br>                    b.Navigation("ServiceLines");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =><br>                {<br>                    b.Navigation("CDs");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.Navigation("Tracks");<br>                });<br>#pragma warning restore 612, 618<br>        }` |

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

| Name | Signature | Definition |
|------|-----------|-------------|
| `Up` | `protected void Up(MigrationBuilder migrationBuilder)` | `/// <inheritdoc /><br>        protected override void Up(MigrationBuilder migrationBuilder)<br>        {<br>            migrationBuilder.CreateTable(<br>                name: "Albums",<br>                columns: table => new<br>                {<br>                    Id = table.Column<int>(type: "int", nullable: false)<br>                        .Annotation("SqlServer:Identity", "1, 1"),<br>                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false)<br>                },<br>                constraints: table =><br>                {<br>                    table.PrimaryKey("PK_Albums", x => x.Id);<br>                });<br><br>            migrationBuilder.CreateTable(<br>                name: "CDs",<br>                columns: table => new<br>                {<br>                    Id = table.Column<int>(type: "int", nullable: false)<br>                        .Annotation("SqlServer:Identity", "1, 1"),<br>                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),<br>                    Genre = table.Column<int>(type: "int", nullable: false),<br>                    AlbumId = table.Column<int>(type: "int", nullable: false)<br>                },<br>                constraints: table =><br>                {<br>                    table.PrimaryKey("PK_CDs", x => x.Id);<br>                    table.ForeignKey(<br>                        name: "FK_CDs_Albums_AlbumId",<br>                        column: x => x.AlbumId,<br>                        principalTable: "Albums",<br>                        principalColumn: "Id",<br>                        onDelete: ReferentialAction.Cascade);<br>                });<br><br>            migrationBuilder.CreateTable(<br>                name: "Tracks",<br>                columns: table => new<br>                {<br>                    Id = table.Column<int>(type: "int", nullable: false)<br>                        .Annotation("SqlServer:Identity", "1, 1"),<br>                    Number = table.Column<int>(type: "int", nullable: false),<br>                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),<br>                    Length = table.Column<TimeSpan>(type: "time", nullable: false),<br>                    CDId = table.Column<int>(type: "int", nullable: false)<br>                },<br>                constraints: table =><br>                {<br>                    table.PrimaryKey("PK_Tracks", x => x.Id);<br>                    table.ForeignKey(<br>                        name: "FK_Tracks_CDs_CDId",<br>                        column: x => x.CDId,<br>                        principalTable: "CDs",<br>                        principalColumn: "Id",<br>                        onDelete: ReferentialAction.Cascade);<br>                });<br><br>            migrationBuilder.CreateIndex(<br>                name: "IX_CDs_AlbumId",<br>                table: "CDs",<br>                column: "AlbumId");<br><br>            migrationBuilder.CreateIndex(<br>                name: "IX_Tracks_CDId",<br>                table: "Tracks",<br>                column: "CDId");<br>        }` |
| `Down` | `protected void Down(MigrationBuilder migrationBuilder)` | `/// <inheritdoc /><br>        protected override void Down(MigrationBuilder migrationBuilder)<br>        {<br>            migrationBuilder.DropTable(<br>                name: "Tracks");<br><br>            migrationBuilder.DropTable(<br>                name: "CDs");<br><br>            migrationBuilder.DropTable(<br>                name: "Albums");<br>        }` |

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

| Name | Signature | Definition |
|------|-----------|-------------|
| `BuildTargetModel` | `protected void BuildTargetModel(ModelBuilder modelBuilder)` | `/// <inheritdoc /><br>        protected override void BuildTargetModel(ModelBuilder modelBuilder)<br>        {<br>#pragma warning disable 612, 618<br>            modelBuilder<br>                .HasAnnotation("ProductVersion", "9.0.1")<br>                .HasAnnotation("Relational:MaxIdentifierLength", 128);<br><br>            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =><br>                {<br>                    b.Property<int>("Id")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));<br><br>                    b.Property<string>("Artist")<br>                        .IsRequired()<br>                        .HasColumnType("nvarchar(max)");<br><br>                    b.HasKey("Id");<br><br>                    b.ToTable("Albums");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.Property<int>("Id")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));<br><br>                    b.Property<int>("AlbumId")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("Genre")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Name")<br>                        .IsRequired()<br>                        .HasColumnType("nvarchar(max)");<br><br>                    b.HasKey("Id");<br><br>                    b.HasIndex("AlbumId");<br><br>                    b.ToTable("CDs");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =><br>                {<br>                    b.Property<int>("Id")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));<br><br>                    b.Property<int>("CDId")<br>                        .HasColumnType("int");<br><br>                    b.Property<TimeSpan>("Length")<br>                        .HasColumnType("time");<br><br>                    b.Property<int>("Number")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Title")<br>                        .IsRequired()<br>                        .HasColumnType("nvarchar(max)");<br><br>                    b.HasKey("Id");<br><br>                    b.HasIndex("CDId");<br><br>                    b.ToTable("Tracks");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")<br>                        .WithMany("CDs")<br>                        .HasForeignKey("AlbumId")<br>                        .OnDelete(DeleteBehavior.Cascade)<br>                        .IsRequired();<br><br>                    b.Navigation("Album");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")<br>                        .WithMany("Tracks")<br>                        .HasForeignKey("CDId")<br>                        .OnDelete(DeleteBehavior.Cascade)<br>                        .IsRequired();<br><br>                    b.Navigation("CD");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =><br>                {<br>                    b.Navigation("CDs");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.Navigation("Tracks");<br>                });<br>#pragma warning restore 612, 618<br>        }` |

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

| Name | Signature | Definition |
|------|-----------|-------------|
| `Up` | `protected void Up(MigrationBuilder migrationBuilder)` | `/// <inheritdoc /><br>        protected override void Up(MigrationBuilder migrationBuilder)<br>        {<br>            migrationBuilder.DropForeignKey(<br>                name: "FK_Music_CD_Music_Album_AlbumId",<br>                table: "Music_CD");<br><br>            migrationBuilder.DropForeignKey(<br>                name: "FK_Music_Track_Music_CD_CDId",<br>                table: "Music_Track");<br><br>            migrationBuilder.CreateTable(<br>                name: "Medical_Claim",<br>                columns: table => new<br>                {<br>                    FormId = table.Column<int>(type: "int", nullable: false)<br>                        .Annotation("SqlServer:Identity", "1, 1"),<br>                    InsuranceProgram = table.Column<int>(type: "int", nullable: false),<br>                    InsuredIdNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),<br>                    Patient_LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),<br>                    Patient_FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),<br>                    Patient_BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),<br>                    Patient_Sex = table.Column<int>(type: "int", nullable: false),<br>                    Patient_RelationshipToInsured = table.Column<int>(type: "int", nullable: false),<br>                    Insured_LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),<br>                    Insured_FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),<br>                    Insured_GroupNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),<br>                    OtherInsurance_PolicyHolderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),<br>                    OtherInsurance_PolicyNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),<br>                    OtherInsurance_PlanName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),<br>                    OtherInsurance_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),<br>                    ConditionRelated_Employment = table.Column<bool>(type: "bit", nullable: false),<br>                    ConditionRelated_AutoAccident = table.Column<bool>(type: "bit", nullable: false),<br>                    ConditionRelated_OtherAccident = table.Column<bool>(type: "bit", nullable: false),<br>                    ConditionRelated_AccidentState = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),<br>                    BillingProvider_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),<br>                    BillingProvider_FederalTaxId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),<br>                    BillingProvider_NpiNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),<br>                    BillingProvider_Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),<br>                    ServiceFacility_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),<br>                    ServiceFacility_FederalTaxId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),<br>                    ServiceFacility_NpiNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),<br>                    ServiceFacility_Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),<br>                    TotalCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),<br>                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),<br>                    PatientSignatureDate = table.Column<DateTime>(type: "datetime2", nullable: false),<br>                    PhysicianSignatureDate = table.Column<DateTime>(type: "datetime2", nullable: false),<br>                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),<br>                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)<br>                },<br>                constraints: table =><br>                {<br>                    table.PrimaryKey("PK_Medical_Claim", x => x.FormId);<br>                });<br><br>            migrationBuilder.CreateTable(<br>                name: "Medical_Claim_BillingProviderAddress",<br>                columns: table => new<br>                {<br>                    AddressId = table.Column<int>(type: "int", nullable: false),<br>                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),<br>                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),<br>                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),<br>                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),<br>                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)<br>                },<br>                constraints: table =><br>                {<br>                    table.PrimaryKey("PK_Medical_Claim_BillingProviderAddress", x => x.AddressId);<br>                    table.ForeignKey(<br>                        name: "FK_Medical_Claim_BillingProviderAddress_Medical_Claim_AddressId",<br>                        column: x => x.AddressId,<br>                        principalTable: "Medical_Claim",<br>                        principalColumn: "FormId",<br>                        onDelete: ReferentialAction.Cascade);<br>                });<br><br>            migrationBuilder.CreateTable(<br>                name: "Medical_Claim_Diagnosis",<br>                columns: table => new<br>                {<br>                    DiagnosisId = table.Column<int>(type: "int", nullable: false)<br>                        .Annotation("SqlServer:Identity", "1, 1"),<br>                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),<br>                    Priority = table.Column<int>(type: "int", nullable: false),<br>                    ClaimId = table.Column<int>(type: "int", nullable: false)<br>                },<br>                constraints: table =><br>                {<br>                    table.PrimaryKey("PK_Medical_Claim_Diagnosis", x => x.DiagnosisId);<br>                    table.ForeignKey(<br>                        name: "FK_Medical_Claim_Diagnosis_Medical_Claim_ClaimId",<br>                        column: x => x.ClaimId,<br>                        principalTable: "Medical_Claim",<br>                        principalColumn: "FormId",<br>                        onDelete: ReferentialAction.Cascade);<br>                });<br><br>            migrationBuilder.CreateTable(<br>                name: "Medical_Claim_InsuredAddress",<br>                columns: table => new<br>                {<br>                    AddressId = table.Column<int>(type: "int", nullable: false),<br>                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),<br>                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),<br>                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),<br>                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),<br>                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)<br>                },<br>                constraints: table =><br>                {<br>                    table.PrimaryKey("PK_Medical_Claim_InsuredAddress", x => x.AddressId);<br>                    table.ForeignKey(<br>                        name: "FK_Medical_Claim_InsuredAddress_Medical_Claim_AddressId",<br>                        column: x => x.AddressId,<br>                        principalTable: "Medical_Claim",<br>                        principalColumn: "FormId",<br>                        onDelete: ReferentialAction.Cascade);<br>                });<br><br>            migrationBuilder.CreateTable(<br>                name: "Medical_Claim_PatientAddress",<br>                columns: table => new<br>                {<br>                    AddressId = table.Column<int>(type: "int", nullable: false),<br>                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),<br>                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),<br>                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),<br>                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),<br>                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)<br>                },<br>                constraints: table =><br>                {<br>                    table.PrimaryKey("PK_Medical_Claim_PatientAddress", x => x.AddressId);<br>                    table.ForeignKey(<br>                        name: "FK_Medical_Claim_PatientAddress_Medical_Claim_AddressId",<br>                        column: x => x.AddressId,<br>                        principalTable: "Medical_Claim",<br>                        principalColumn: "FormId",<br>                        onDelete: ReferentialAction.Cascade);<br>                });<br><br>            migrationBuilder.CreateTable(<br>                name: "Medical_Claim_ServiceFacilityAddress",<br>                columns: table => new<br>                {<br>                    AddressId = table.Column<int>(type: "int", nullable: false),<br>                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),<br>                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),<br>                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),<br>                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),<br>                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)<br>                },<br>                constraints: table =><br>                {<br>                    table.PrimaryKey("PK_Medical_Claim_ServiceFacilityAddress", x => x.AddressId);<br>                    table.ForeignKey(<br>                        name: "FK_Medical_Claim_ServiceFacilityAddress_Medical_Claim_AddressId",<br>                        column: x => x.AddressId,<br>                        principalTable: "Medical_Claim",<br>                        principalColumn: "FormId",<br>                        onDelete: ReferentialAction.Cascade);<br>                });<br><br>            migrationBuilder.CreateTable(<br>                name: "Medical_Claim_ServiceLine",<br>                columns: table => new<br>                {<br>                    ServiceLineId = table.Column<int>(type: "int", nullable: false)<br>                        .Annotation("SqlServer:Identity", "1, 1"),<br>                    ServiceStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),<br>                    ServiceEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),<br>                    ProcedureCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),<br>                    Modifier = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),<br>                    DiagnosisPointer = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),<br>                    Charge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),<br>                    RenderingProviderId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),<br>                    ClaimId = table.Column<int>(type: "int", nullable: false)<br>                },<br>                constraints: table =><br>                {<br>                    table.PrimaryKey("PK_Medical_Claim_ServiceLine", x => x.ServiceLineId);<br>                    table.ForeignKey(<br>                        name: "FK_Medical_Claim_ServiceLine_Medical_Claim_ClaimId",<br>                        column: x => x.ClaimId,<br>                        principalTable: "Medical_Claim",<br>                        principalColumn: "FormId",<br>                        onDelete: ReferentialAction.Cascade);<br>                });<br><br>            migrationBuilder.CreateIndex(<br>                name: "IX_Medical_Claim_Diagnosis_ClaimId",<br>                table: "Medical_Claim_Diagnosis",<br>                column: "ClaimId");<br><br>            migrationBuilder.CreateIndex(<br>                name: "IX_Medical_Claim_ServiceLine_ClaimId",<br>                table: "Medical_Claim_ServiceLine",<br>                column: "ClaimId");<br><br>            migrationBuilder.AddForeignKey(<br>                name: "FK_Music_CD_Music_Album_AlbumId",<br>                table: "Music_CD",<br>                column: "AlbumId",<br>                principalTable: "Music_Album",<br>                principalColumn: "ID",<br>                onDelete: ReferentialAction.Restrict);<br><br>            migrationBuilder.AddForeignKey(<br>                name: "FK_Music_Track_Music_CD_CDId",<br>                table: "Music_Track",<br>                column: "CDId",<br>                principalTable: "Music_CD",<br>                principalColumn: "ID",<br>                onDelete: ReferentialAction.Restrict);<br>        }` |
| `Down` | `protected void Down(MigrationBuilder migrationBuilder)` | `/// <inheritdoc /><br>        protected override void Down(MigrationBuilder migrationBuilder)<br>        {<br>            migrationBuilder.DropForeignKey(<br>                name: "FK_Music_CD_Music_Album_AlbumId",<br>                table: "Music_CD");<br><br>            migrationBuilder.DropForeignKey(<br>                name: "FK_Music_Track_Music_CD_CDId",<br>                table: "Music_Track");<br><br>            migrationBuilder.DropTable(<br>                name: "Medical_Claim_BillingProviderAddress");<br><br>            migrationBuilder.DropTable(<br>                name: "Medical_Claim_Diagnosis");<br><br>            migrationBuilder.DropTable(<br>                name: "Medical_Claim_InsuredAddress");<br><br>            migrationBuilder.DropTable(<br>                name: "Medical_Claim_PatientAddress");<br><br>            migrationBuilder.DropTable(<br>                name: "Medical_Claim_ServiceFacilityAddress");<br><br>            migrationBuilder.DropTable(<br>                name: "Medical_Claim_ServiceLine");<br><br>            migrationBuilder.DropTable(<br>                name: "Medical_Claim");<br><br>            migrationBuilder.AddForeignKey(<br>                name: "FK_Music_CD_Music_Album_AlbumId",<br>                table: "Music_CD",<br>                column: "AlbumId",<br>                principalTable: "Music_Album",<br>                principalColumn: "ID",<br>                onDelete: ReferentialAction.Cascade);<br><br>            migrationBuilder.AddForeignKey(<br>                name: "FK_Music_Track_Music_CD_CDId",<br>                table: "Music_Track",<br>                column: "CDId",<br>                principalTable: "Music_CD",<br>                principalColumn: "ID",<br>                onDelete: ReferentialAction.Cascade);<br>        }` |

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

| Name | Signature | Definition |
|------|-----------|-------------|
| `BuildTargetModel` | `protected void BuildTargetModel(ModelBuilder modelBuilder)` | `/// <inheritdoc /><br>        protected override void BuildTargetModel(ModelBuilder modelBuilder)<br>        {<br>#pragma warning disable 612, 618<br>            modelBuilder<br>                .HasAnnotation("ProductVersion", "9.0.1")<br>                .HasAnnotation("Relational:MaxIdentifierLength", 128);<br><br>            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Management.TaskItem", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<DateTime>("CreatedDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.Property<string>("Description")<br>                        .IsRequired()<br>                        .HasMaxLength(5000)<br>                        .HasColumnType("nvarchar(max)");<br><br>                    b.Property<bool>("IsCompleted")<br>                        .HasColumnType("bit");<br><br>                    b.Property<int?>("TaskObjectId")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("TaskObjectType")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("TaskSubType")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("TaskType")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Title")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.Property<DateTime?>("UpdatedDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.HasKey("ID");<br><br>                    b.ToTable("Management_TaskItem");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =><br>                {<br>                    b.Property<int>("FormId")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormId"));<br><br>                    b.Property<decimal>("AmountPaid")<br>                        .HasColumnType("decimal(18,2)");<br><br>                    b.Property<DateTime>("CreatedDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.Property<int>("InsuranceProgram")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("InsuredIdNumber")<br>                        .HasMaxLength(20)<br>                        .HasColumnType("nvarchar(20)");<br><br>                    b.Property<DateTime>("PatientSignatureDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.Property<DateTime>("PhysicianSignatureDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.Property<decimal>("TotalCharge")<br>                        .HasColumnType("decimal(18,2)");<br><br>                    b.Property<DateTime?>("UpdatedDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.HasKey("FormId");<br><br>                    b.ToTable("Medical_Claim");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =><br>                {<br>                    b.Property<int>("DiagnosisId")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));<br><br>                    b.Property<int>("ClaimId")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Code")<br>                        .IsRequired()<br>                        .HasMaxLength(10)<br>                        .HasColumnType("nvarchar(10)");<br><br>                    b.Property<int>("Priority")<br>                        .HasColumnType("int");<br><br>                    b.HasKey("DiagnosisId");<br><br>                    b.HasIndex("ClaimId");<br><br>                    b.ToTable("Medical_Claim_Diagnosis");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =><br>                {<br>                    b.Property<int>("ServiceLineId")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceLineId"));<br><br>                    b.Property<decimal>("Charge")<br>                        .HasColumnType("decimal(18,2)");<br><br>                    b.Property<int>("ClaimId")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("DiagnosisPointer")<br>                        .HasMaxLength(10)<br>                        .HasColumnType("nvarchar(10)");<br><br>                    b.Property<string>("Modifier")<br>                        .HasMaxLength(2)<br>                        .HasColumnType("nvarchar(2)");<br><br>                    b.Property<string>("ProcedureCode")<br>                        .IsRequired()<br>                        .HasMaxLength(10)<br>                        .HasColumnType("nvarchar(10)");<br><br>                    b.Property<string>("RenderingProviderId")<br>                        .IsRequired()<br>                        .HasMaxLength(20)<br>                        .HasColumnType("nvarchar(20)");<br><br>                    b.Property<DateTime>("ServiceEndDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.Property<DateTime>("ServiceStartDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.HasKey("ServiceLineId");<br><br>                    b.HasIndex("ClaimId");<br><br>                    b.ToTable("Medical_Claim_ServiceLine");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<string>("ArtistName")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.ToTable("Music_Album");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<int>("AlbumId")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("Genre")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Name")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.HasIndex("AlbumId");<br><br>                    b.ToTable("Music_CD");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<int>("CDId")<br>                        .HasColumnType("int");<br><br>                    b.Property<TimeSpan>("Length")<br>                        .HasColumnType("time");<br><br>                    b.Property<int>("Number")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Title")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.HasIndex("CDId");<br><br>                    b.ToTable("Music_Track");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =><br>                {<br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "BillingProvider", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<string>("FederalTaxId")<br>                                .IsRequired()<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.Property<string>("Name")<br>                                .IsRequired()<br>                                .HasMaxLength(100)<br>                                .HasColumnType("nvarchar(100)");<br><br>                            b1.Property<string>("NpiNumber")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.Property<string>("Phone")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br><br>                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =><br>                                {<br>                                    b2.Property<int>("AddressId")<br>                                        .HasColumnType("int");<br><br>                                    b2.Property<string>("City")<br>                                        .HasMaxLength(50)<br>                                        .HasColumnType("nvarchar(50)");<br><br>                                    b2.Property<string>("Phone")<br>                                        .HasMaxLength(20)<br>                                        .HasColumnType("nvarchar(20)");<br><br>                                    b2.Property<string>("State")<br>                                        .HasMaxLength(2)<br>                                        .HasColumnType("nvarchar(2)");<br><br>                                    b2.Property<string>("Street")<br>                                        .HasMaxLength(100)<br>                                        .HasColumnType("nvarchar(100)");<br><br>                                    b2.Property<string>("ZipCode")<br>                                        .HasMaxLength(10)<br>                                        .HasColumnType("nvarchar(10)");<br><br>                                    b2.HasKey("AddressId");<br><br>                                    b2.ToTable("Medical_Claim_BillingProviderAddress", (string)null);<br><br>                                    b2.WithOwner()<br>                                        .HasForeignKey("AddressId");<br>                                });<br><br>                            b1.Navigation("Address")<br>                                .IsRequired();<br>                        });<br><br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.ProviderInfo", "ServiceFacility", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<string>("FederalTaxId")<br>                                .IsRequired()<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.Property<string>("Name")<br>                                .IsRequired()<br>                                .HasMaxLength(100)<br>                                .HasColumnType("nvarchar(100)");<br><br>                            b1.Property<string>("NpiNumber")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.Property<string>("Phone")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br><br>                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =><br>                                {<br>                                    b2.Property<int>("AddressId")<br>                                        .HasColumnType("int");<br><br>                                    b2.Property<string>("City")<br>                                        .HasMaxLength(50)<br>                                        .HasColumnType("nvarchar(50)");<br><br>                                    b2.Property<string>("Phone")<br>                                        .HasMaxLength(20)<br>                                        .HasColumnType("nvarchar(20)");<br><br>                                    b2.Property<string>("State")<br>                                        .HasMaxLength(2)<br>                                        .HasColumnType("nvarchar(2)");<br><br>                                    b2.Property<string>("Street")<br>                                        .HasMaxLength(100)<br>                                        .HasColumnType("nvarchar(100)");<br><br>                                    b2.Property<string>("ZipCode")<br>                                        .HasMaxLength(10)<br>                                        .HasColumnType("nvarchar(10)");<br><br>                                    b2.HasKey("AddressId");<br><br>                                    b2.ToTable("Medical_Claim_ServiceFacilityAddress", (string)null);<br><br>                                    b2.WithOwner()<br>                                        .HasForeignKey("AddressId");<br>                                });<br><br>                            b1.Navigation("Address")<br>                                .IsRequired();<br>                        });<br><br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.ConditionRelated", "ConditionRelated", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<string>("AccidentState")<br>                                .HasMaxLength(2)<br>                                .HasColumnType("nvarchar(2)");<br><br>                            b1.Property<bool>("AutoAccident")<br>                                .HasColumnType("bit");<br><br>                            b1.Property<bool>("Employment")<br>                                .HasColumnType("bit");<br><br>                            b1.Property<bool>("OtherAccident")<br>                                .HasColumnType("bit");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br>                        });<br><br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.InsuredInfo", "Insured", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<string>("FirstName")<br>                                .IsRequired()<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.Property<string>("GroupNumber")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.Property<string>("LastName")<br>                                .IsRequired()<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br><br>                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =><br>                                {<br>                                    b2.Property<int>("AddressId")<br>                                        .HasColumnType("int");<br><br>                                    b2.Property<string>("City")<br>                                        .HasMaxLength(50)<br>                                        .HasColumnType("nvarchar(50)");<br><br>                                    b2.Property<string>("Phone")<br>                                        .HasMaxLength(20)<br>                                        .HasColumnType("nvarchar(20)");<br><br>                                    b2.Property<string>("State")<br>                                        .HasMaxLength(2)<br>                                        .HasColumnType("nvarchar(2)");<br><br>                                    b2.Property<string>("Street")<br>                                        .HasMaxLength(100)<br>                                        .HasColumnType("nvarchar(100)");<br><br>                                    b2.Property<string>("ZipCode")<br>                                        .HasMaxLength(10)<br>                                        .HasColumnType("nvarchar(10)");<br><br>                                    b2.HasKey("AddressId");<br><br>                                    b2.ToTable("Medical_Claim_InsuredAddress", (string)null);<br><br>                                    b2.WithOwner()<br>                                        .HasForeignKey("AddressId");<br>                                });<br><br>                            b1.Navigation("Address")<br>                                .IsRequired();<br>                        });<br><br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.OtherInsuranceInfo", "OtherInsurance", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<DateTime>("CreatedDate")<br>                                .HasColumnType("datetime2");<br><br>                            b1.Property<string>("PlanName")<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.Property<string>("PolicyHolderName")<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.Property<string>("PolicyNumber")<br>                                .HasMaxLength(20)<br>                                .HasColumnType("nvarchar(20)");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br>                        });<br><br>                    b.OwnsOne("MyApp.Domain.Entities.Medical.PatientInfo", "Patient", b1 =><br>                        {<br>                            b1.Property<int>("ClaimFormId")<br>                                .HasColumnType("int");<br><br>                            b1.Property<DateTime>("BirthDate")<br>                                .HasColumnType("datetime2");<br><br>                            b1.Property<string>("FirstName")<br>                                .IsRequired()<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.Property<string>("LastName")<br>                                .IsRequired()<br>                                .HasMaxLength(50)<br>                                .HasColumnType("nvarchar(50)");<br><br>                            b1.Property<int>("RelationshipToInsured")<br>                                .HasColumnType("int");<br><br>                            b1.Property<int>("Sex")<br>                                .HasColumnType("int");<br><br>                            b1.HasKey("ClaimFormId");<br><br>                            b1.ToTable("Medical_Claim");<br><br>                            b1.WithOwner()<br>                                .HasForeignKey("ClaimFormId");<br><br>                            b1.OwnsOne("MyApp.Domain.Entities.Medical.Address", "Address", b2 =><br>                                {<br>                                    b2.Property<int>("AddressId")<br>                                        .HasColumnType("int");<br><br>                                    b2.Property<string>("City")<br>                                        .HasMaxLength(50)<br>                                        .HasColumnType("nvarchar(50)");<br><br>                                    b2.Property<string>("Phone")<br>                                        .HasMaxLength(20)<br>                                        .HasColumnType("nvarchar(20)");<br><br>                                    b2.Property<string>("State")<br>                                        .HasMaxLength(2)<br>                                        .HasColumnType("nvarchar(2)");<br><br>                                    b2.Property<string>("Street")<br>                                        .HasMaxLength(100)<br>                                        .HasColumnType("nvarchar(100)");<br><br>                                    b2.Property<string>("ZipCode")<br>                                        .HasMaxLength(10)<br>                                        .HasColumnType("nvarchar(10)");<br><br>                                    b2.HasKey("AddressId");<br><br>                                    b2.ToTable("Medical_Claim_PatientAddress", (string)null);<br><br>                                    b2.WithOwner()<br>                                        .HasForeignKey("AddressId");<br>                                });<br><br>                            b1.Navigation("Address")<br>                                .IsRequired();<br>                        });<br><br>                    b.Navigation("BillingProvider")<br>                        .IsRequired();<br><br>                    b.Navigation("ConditionRelated")<br>                        .IsRequired();<br><br>                    b.Navigation("Insured")<br>                        .IsRequired();<br><br>                    b.Navigation("OtherInsurance");<br><br>                    b.Navigation("Patient")<br>                        .IsRequired();<br><br>                    b.Navigation("ServiceFacility")<br>                        .IsRequired();<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.DiagnosisCode", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")<br>                        .WithMany("DiagnosisCodes")<br>                        .HasForeignKey("ClaimId")<br>                        .OnDelete(DeleteBehavior.Cascade)<br>                        .IsRequired();<br><br>                    b.Navigation("Claim");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.ServiceLine", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Medical.Claim", "Claim")<br>                        .WithMany("ServiceLines")<br>                        .HasForeignKey("ClaimId")<br>                        .OnDelete(DeleteBehavior.Cascade)<br>                        .IsRequired();<br><br>                    b.Navigation("Claim");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")<br>                        .WithMany("CDs")<br>                        .HasForeignKey("AlbumId")<br>                        .OnDelete(DeleteBehavior.Restrict)<br>                        .IsRequired();<br><br>                    b.Navigation("Album");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")<br>                        .WithMany("Tracks")<br>                        .HasForeignKey("CDId")<br>                        .OnDelete(DeleteBehavior.Restrict)<br>                        .IsRequired();<br><br>                    b.Navigation("CD");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Medical.Claim", b =><br>                {<br>                    b.Navigation("DiagnosisCodes");<br><br>                    b.Navigation("ServiceLines");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =><br>                {<br>                    b.Navigation("CDs");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.Navigation("Tracks");<br>                });<br>#pragma warning restore 612, 618<br>        }` |

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

| Name | Signature | Definition |
|------|-----------|-------------|
| `Up` | `protected void Up(MigrationBuilder migrationBuilder)` | `/// <inheritdoc /><br>        protected override void Up(MigrationBuilder migrationBuilder)<br>        {<br>            migrationBuilder.CreateTable(<br>                name: "Management_TaskItem",<br>                columns: table => new<br>                {<br>                    ID = table.Column<int>(type: "int", nullable: false)<br>                        .Annotation("SqlServer:Identity", "1, 1"),<br>                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),<br>                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),<br>                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),<br>                    TaskType = table.Column<int>(type: "int", nullable: false),<br>                    TaskSubType = table.Column<int>(type: "int", nullable: false),<br>                    TaskObjectType = table.Column<int>(type: "int", nullable: false),<br>                    TaskObjectId = table.Column<int>(type: "int", nullable: true),<br>                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),<br>                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)<br>                },<br>                constraints: table =><br>                {<br>                    table.PrimaryKey("PK_Management_TaskItem", x => x.ID);<br>                });<br>        }` |
| `Down` | `protected void Down(MigrationBuilder migrationBuilder)` | `/// <inheritdoc /><br>        protected override void Down(MigrationBuilder migrationBuilder)<br>        {<br>            migrationBuilder.DropTable(<br>                name: "Management_TaskItem");<br>        }` |

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

| Name | Signature | Definition |
|------|-----------|-------------|
| `BuildTargetModel` | `protected void BuildTargetModel(ModelBuilder modelBuilder)` | `/// <inheritdoc /><br>        protected override void BuildTargetModel(ModelBuilder modelBuilder)<br>        {<br>#pragma warning disable 612, 618<br>            modelBuilder<br>                .HasAnnotation("ProductVersion", "9.0.1")<br>                .HasAnnotation("Relational:MaxIdentifierLength", 128);<br><br>            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Management.TaskItem", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<DateTime>("CreatedDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.Property<string>("Description")<br>                        .IsRequired()<br>                        .HasMaxLength(5000)<br>                        .HasColumnType("nvarchar(max)");<br><br>                    b.Property<bool>("IsCompleted")<br>                        .HasColumnType("bit");<br><br>                    b.Property<int?>("TaskObjectId")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("TaskObjectType")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("TaskSubType")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("TaskType")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Title")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.Property<DateTime?>("UpdatedDate")<br>                        .HasColumnType("datetime2");<br><br>                    b.HasKey("ID");<br><br>                    b.ToTable("Management_TaskItem");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<string>("ArtistName")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.ToTable("Music_Album");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<int>("AlbumId")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("Genre")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Name")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.HasIndex("AlbumId");<br><br>                    b.ToTable("Music_CD");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<int>("CDId")<br>                        .HasColumnType("int");<br><br>                    b.Property<TimeSpan>("Length")<br>                        .HasColumnType("time");<br><br>                    b.Property<int>("Number")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Title")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.HasIndex("CDId");<br><br>                    b.ToTable("Music_Track");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")<br>                        .WithMany("CDs")<br>                        .HasForeignKey("AlbumId")<br>                        .OnDelete(DeleteBehavior.Cascade)<br>                        .IsRequired();<br><br>                    b.Navigation("Album");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")<br>                        .WithMany("Tracks")<br>                        .HasForeignKey("CDId")<br>                        .OnDelete(DeleteBehavior.Cascade)<br>                        .IsRequired();<br><br>                    b.Navigation("CD");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =><br>                {<br>                    b.Navigation("CDs");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.Navigation("Tracks");<br>                });<br>#pragma warning restore 612, 618<br>        }` |

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

| Name | Signature | Definition |
|------|-----------|-------------|
| `Up` | `protected void Up(MigrationBuilder migrationBuilder)` | `/// <inheritdoc /><br>        protected override void Up(MigrationBuilder migrationBuilder)<br>        {<br>            migrationBuilder.DropForeignKey(<br>                name: "FK_CDs_Albums_AlbumId",<br>                table: "CDs");<br><br>            migrationBuilder.DropForeignKey(<br>                name: "FK_Tracks_CDs_CDId",<br>                table: "Tracks");<br><br>            migrationBuilder.DropPrimaryKey(<br>                name: "PK_Tracks",<br>                table: "Tracks");<br><br>            migrationBuilder.DropPrimaryKey(<br>                name: "PK_CDs",<br>                table: "CDs");<br><br>            migrationBuilder.DropPrimaryKey(<br>                name: "PK_Albums",<br>                table: "Albums");<br><br>            migrationBuilder.DropColumn(<br>                name: "Artist",<br>                table: "Albums");<br><br>            migrationBuilder.RenameTable(<br>                name: "Tracks",<br>                newName: "Music_Track");<br><br>            migrationBuilder.RenameTable(<br>                name: "CDs",<br>                newName: "Music_CD");<br><br>            migrationBuilder.RenameTable(<br>                name: "Albums",<br>                newName: "Music_Album");<br><br>            migrationBuilder.RenameColumn(<br>                name: "Id",<br>                table: "Music_Track",<br>                newName: "ID");<br><br>            migrationBuilder.RenameIndex(<br>                name: "IX_Tracks_CDId",<br>                table: "Music_Track",<br>                newName: "IX_Music_Track_CDId");<br><br>            migrationBuilder.RenameColumn(<br>                name: "Id",<br>                table: "Music_CD",<br>                newName: "ID");<br><br>            migrationBuilder.RenameIndex(<br>                name: "IX_CDs_AlbumId",<br>                table: "Music_CD",<br>                newName: "IX_Music_CD_AlbumId");<br><br>            migrationBuilder.RenameColumn(<br>                name: "Id",<br>                table: "Music_Album",<br>                newName: "ID");<br><br>            migrationBuilder.AlterColumn<string>(<br>                name: "Title",<br>                table: "Music_Track",<br>                type: "nvarchar(500)",<br>                maxLength: 500,<br>                nullable: false,<br>                oldClrType: typeof(string),<br>                oldType: "nvarchar(max)");<br><br>            migrationBuilder.AlterColumn<string>(<br>                name: "Name",<br>                table: "Music_CD",<br>                type: "nvarchar(500)",<br>                maxLength: 500,<br>                nullable: false,<br>                oldClrType: typeof(string),<br>                oldType: "nvarchar(max)");<br><br>            migrationBuilder.AddColumn<string>(<br>                name: "ArtistName",<br>                table: "Music_Album",<br>                type: "nvarchar(500)",<br>                maxLength: 500,<br>                nullable: false,<br>                defaultValue: "");<br><br>            migrationBuilder.AddPrimaryKey(<br>                name: "PK_Music_Track",<br>                table: "Music_Track",<br>                column: "ID");<br><br>            migrationBuilder.AddPrimaryKey(<br>                name: "PK_Music_CD",<br>                table: "Music_CD",<br>                column: "ID");<br><br>            migrationBuilder.AddPrimaryKey(<br>                name: "PK_Music_Album",<br>                table: "Music_Album",<br>                column: "ID");<br><br>            migrationBuilder.AddForeignKey(<br>                name: "FK_Music_CD_Music_Album_AlbumId",<br>                table: "Music_CD",<br>                column: "AlbumId",<br>                principalTable: "Music_Album",<br>                principalColumn: "ID",<br>                onDelete: ReferentialAction.Cascade);<br><br>            migrationBuilder.AddForeignKey(<br>                name: "FK_Music_Track_Music_CD_CDId",<br>                table: "Music_Track",<br>                column: "CDId",<br>                principalTable: "Music_CD",<br>                principalColumn: "ID",<br>                onDelete: ReferentialAction.Cascade);<br>        }` |
| `Down` | `protected void Down(MigrationBuilder migrationBuilder)` | `/// <inheritdoc /><br>        protected override void Down(MigrationBuilder migrationBuilder)<br>        {<br>            migrationBuilder.DropForeignKey(<br>                name: "FK_Music_CD_Music_Album_AlbumId",<br>                table: "Music_CD");<br><br>            migrationBuilder.DropForeignKey(<br>                name: "FK_Music_Track_Music_CD_CDId",<br>                table: "Music_Track");<br><br>            migrationBuilder.DropPrimaryKey(<br>                name: "PK_Music_Track",<br>                table: "Music_Track");<br><br>            migrationBuilder.DropPrimaryKey(<br>                name: "PK_Music_CD",<br>                table: "Music_CD");<br><br>            migrationBuilder.DropPrimaryKey(<br>                name: "PK_Music_Album",<br>                table: "Music_Album");<br><br>            migrationBuilder.DropColumn(<br>                name: "ArtistName",<br>                table: "Music_Album");<br><br>            migrationBuilder.RenameTable(<br>                name: "Music_Track",<br>                newName: "Tracks");<br><br>            migrationBuilder.RenameTable(<br>                name: "Music_CD",<br>                newName: "CDs");<br><br>            migrationBuilder.RenameTable(<br>                name: "Music_Album",<br>                newName: "Albums");<br><br>            migrationBuilder.RenameColumn(<br>                name: "ID",<br>                table: "Tracks",<br>                newName: "Id");<br><br>            migrationBuilder.RenameIndex(<br>                name: "IX_Music_Track_CDId",<br>                table: "Tracks",<br>                newName: "IX_Tracks_CDId");<br><br>            migrationBuilder.RenameColumn(<br>                name: "ID",<br>                table: "CDs",<br>                newName: "Id");<br><br>            migrationBuilder.RenameIndex(<br>                name: "IX_Music_CD_AlbumId",<br>                table: "CDs",<br>                newName: "IX_CDs_AlbumId");<br><br>            migrationBuilder.RenameColumn(<br>                name: "ID",<br>                table: "Albums",<br>                newName: "Id");<br><br>            migrationBuilder.AlterColumn<string>(<br>                name: "Title",<br>                table: "Tracks",<br>                type: "nvarchar(max)",<br>                nullable: false,<br>                oldClrType: typeof(string),<br>                oldType: "nvarchar(500)",<br>                oldMaxLength: 500);<br><br>            migrationBuilder.AlterColumn<string>(<br>                name: "Name",<br>                table: "CDs",<br>                type: "nvarchar(max)",<br>                nullable: false,<br>                oldClrType: typeof(string),<br>                oldType: "nvarchar(500)",<br>                oldMaxLength: 500);<br><br>            migrationBuilder.AddColumn<string>(<br>                name: "Artist",<br>                table: "Albums",<br>                type: "nvarchar(max)",<br>                nullable: false,<br>                defaultValue: "");<br><br>            migrationBuilder.AddPrimaryKey(<br>                name: "PK_Tracks",<br>                table: "Tracks",<br>                column: "Id");<br><br>            migrationBuilder.AddPrimaryKey(<br>                name: "PK_CDs",<br>                table: "CDs",<br>                column: "Id");<br><br>            migrationBuilder.AddPrimaryKey(<br>                name: "PK_Albums",<br>                table: "Albums",<br>                column: "Id");<br><br>            migrationBuilder.AddForeignKey(<br>                name: "FK_CDs_Albums_AlbumId",<br>                table: "CDs",<br>                column: "AlbumId",<br>                principalTable: "Albums",<br>                principalColumn: "Id",<br>                onDelete: ReferentialAction.Cascade);<br><br>            migrationBuilder.AddForeignKey(<br>                name: "FK_Tracks_CDs_CDId",<br>                table: "Tracks",<br>                column: "CDId",<br>                principalTable: "CDs",<br>                principalColumn: "Id",<br>                onDelete: ReferentialAction.Cascade);<br>        }` |

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

| Name | Signature | Definition |
|------|-----------|-------------|
| `BuildTargetModel` | `protected void BuildTargetModel(ModelBuilder modelBuilder)` | `/// <inheritdoc /><br>        protected override void BuildTargetModel(ModelBuilder modelBuilder)<br>        {<br>#pragma warning disable 612, 618<br>            modelBuilder<br>                .HasAnnotation("ProductVersion", "9.0.1")<br>                .HasAnnotation("Relational:MaxIdentifierLength", 128);<br><br>            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<string>("ArtistName")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.ToTable("Music_Album");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<int>("AlbumId")<br>                        .HasColumnType("int");<br><br>                    b.Property<int>("Genre")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Name")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.HasIndex("AlbumId");<br><br>                    b.ToTable("Music_CD");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =><br>                {<br>                    b.Property<int>("ID")<br>                        .ValueGeneratedOnAdd()<br>                        .HasColumnType("int");<br><br>                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));<br><br>                    b.Property<int>("CDId")<br>                        .HasColumnType("int");<br><br>                    b.Property<TimeSpan>("Length")<br>                        .HasColumnType("time");<br><br>                    b.Property<int>("Number")<br>                        .HasColumnType("int");<br><br>                    b.Property<string>("Title")<br>                        .IsRequired()<br>                        .HasMaxLength(500)<br>                        .HasColumnType("nvarchar(500)");<br><br>                    b.HasKey("ID");<br><br>                    b.HasIndex("CDId");<br><br>                    b.ToTable("Music_Track");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Music.Album", "Album")<br>                        .WithMany("CDs")<br>                        .HasForeignKey("AlbumId")<br>                        .OnDelete(DeleteBehavior.Cascade)<br>                        .IsRequired();<br><br>                    b.Navigation("Album");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Track", b =><br>                {<br>                    b.HasOne("MyApp.Domain.Entities.Music.CD", "CD")<br>                        .WithMany("Tracks")<br>                        .HasForeignKey("CDId")<br>                        .OnDelete(DeleteBehavior.Cascade)<br>                        .IsRequired();<br><br>                    b.Navigation("CD");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.Album", b =><br>                {<br>                    b.Navigation("CDs");<br>                });<br><br>            modelBuilder.Entity("MyApp.Domain.Entities.Music.CD", b =><br>                {<br>                    b.Navigation("Tracks");<br>                });<br>#pragma warning restore 612, 618<br>        }` |

