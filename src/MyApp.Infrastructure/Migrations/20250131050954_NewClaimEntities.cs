using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewClaimEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medical_Claim_Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "InsuredInfo",
                columns: table => new
                {
                    InsuredInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    GroupNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuredInfo", x => x.InsuredInfoId);
                    table.ForeignKey(
                        name: "FK_InsuredInfo_Medical_Claim_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Medical_Claim_Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    RelationshipToInsured = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientInfo_Medical_Claim_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Medical_Claim_Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProviderInfo",
                columns: table => new
                {
                    ProviderInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FederalTaxId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    NpiNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderInfo", x => x.ProviderInfoId);
                    table.ForeignKey(
                        name: "FK_ProviderInfo_Medical_Claim_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Medical_Claim_Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medical_Claim",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceProgram = table.Column<int>(type: "int", nullable: false),
                    InsuredIdNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    InsuredId = table.Column<int>(type: "int", nullable: false),
                    OtherInsurance_PolicyHolderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OtherInsurance_PolicyNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OtherInsurance_PlanName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BillingProviderId = table.Column<int>(type: "int", nullable: false),
                    ServiceFacilityId = table.Column<int>(type: "int", nullable: false),
                    TotalCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PatientSignatureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhysicianSignatureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConditionRelated_AccidentState = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ConditionRelated_AutoAccident = table.Column<bool>(type: "bit", nullable: false),
                    ConditionRelated_ConditionRelatedId = table.Column<int>(type: "int", nullable: false),
                    ConditionRelated_Employment = table.Column<bool>(type: "bit", nullable: false),
                    ConditionRelated_OtherAccident = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical_Claim", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_InsuredInfo_InsuredId",
                        column: x => x.InsuredId,
                        principalTable: "InsuredInfo",
                        principalColumn: "InsuredInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_PatientInfo_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_ProviderInfo_BillingProviderId",
                        column: x => x.BillingProviderId,
                        principalTable: "ProviderInfo",
                        principalColumn: "ProviderInfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medical_Claim_ProviderInfo_ServiceFacilityId",
                        column: x => x.ServiceFacilityId,
                        principalTable: "ProviderInfo",
                        principalColumn: "ProviderInfoId",
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
                name: "IX_InsuredInfo_AddressId",
                table: "InsuredInfo",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Claim_BillingProviderId",
                table: "Medical_Claim",
                column: "BillingProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Claim_InsuredId",
                table: "Medical_Claim",
                column: "InsuredId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Claim_PatientId",
                table: "Medical_Claim",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Claim_ServiceFacilityId",
                table: "Medical_Claim",
                column: "ServiceFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Claim_Diagnosis_ClaimId",
                table: "Medical_Claim_Diagnosis",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_Medical_Claim_ServiceLine_ClaimId",
                table: "Medical_Claim_ServiceLine",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInfo_AddressId",
                table: "PatientInfo",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderInfo_AddressId",
                table: "ProviderInfo",
                column: "AddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medical_Claim_Diagnosis");

            migrationBuilder.DropTable(
                name: "Medical_Claim_ServiceLine");

            migrationBuilder.DropTable(
                name: "Medical_Claim");

            migrationBuilder.DropTable(
                name: "InsuredInfo");

            migrationBuilder.DropTable(
                name: "PatientInfo");

            migrationBuilder.DropTable(
                name: "ProviderInfo");

            migrationBuilder.DropTable(
                name: "Medical_Claim_Address");
        }
    }
}
