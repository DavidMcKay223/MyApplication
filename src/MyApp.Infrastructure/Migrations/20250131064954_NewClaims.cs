using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastructure.Migrations
{
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
}
