using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixCascadeDelete6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_InsuredInfo_InsuredId",
                table: "Medical_Claim");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_PatientInfo_PatientId",
                table: "Medical_Claim");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_ProviderInfo_BillingProviderId",
                table: "Medical_Claim");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_ProviderInfo_ServiceFacilityId",
                table: "Medical_Claim");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_CD_Music_Album_AlbumId",
                table: "Music_CD");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Track_Music_CD_CDId",
                table: "Music_Track");

            migrationBuilder.DropTable(
                name: "InsuredInfo");

            migrationBuilder.DropTable(
                name: "PatientInfo");

            migrationBuilder.DropTable(
                name: "ProviderInfo");

            migrationBuilder.DropTable(
                name: "Medical_Claim_Address");

            migrationBuilder.DropIndex(
                name: "IX_Medical_Claim_BillingProviderId",
                table: "Medical_Claim");

            migrationBuilder.DropIndex(
                name: "IX_Medical_Claim_InsuredId",
                table: "Medical_Claim");

            migrationBuilder.DropIndex(
                name: "IX_Medical_Claim_PatientId",
                table: "Medical_Claim");

            migrationBuilder.DropIndex(
                name: "IX_Medical_Claim_ServiceFacilityId",
                table: "Medical_Claim");

            migrationBuilder.RenameColumn(
                name: "ConditionRelated_ConditionRelatedId",
                table: "Medical_Claim",
                newName: "Patient_Sex");

            migrationBuilder.AddColumn<string>(
                name: "BillingProvider_FederalTaxId",
                table: "Medical_Claim",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BillingProvider_Name",
                table: "Medical_Claim",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BillingProvider_NpiNumber",
                table: "Medical_Claim",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingProvider_Phone",
                table: "Medical_Claim",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Insured_FirstName",
                table: "Medical_Claim",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Insured_GroupNumber",
                table: "Medical_Claim",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Insured_LastName",
                table: "Medical_Claim",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "OtherInsurance_CreatedDate",
                table: "Medical_Claim",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Patient_BirthDate",
                table: "Medical_Claim",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Patient_FirstName",
                table: "Medical_Claim",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Patient_LastName",
                table: "Medical_Claim",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Patient_RelationshipToInsured",
                table: "Medical_Claim",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ServiceFacility_FederalTaxId",
                table: "Medical_Claim",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ServiceFacility_Name",
                table: "Medical_Claim",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ServiceFacility_NpiNumber",
                table: "Medical_Claim",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceFacility_Phone",
                table: "Medical_Claim",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

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
                name: "Medical_Claim_InsuredAddress");

            migrationBuilder.DropTable(
                name: "Medical_Claim_PatientAddress");

            migrationBuilder.DropTable(
                name: "Medical_Claim_ServiceFacilityAddress");

            migrationBuilder.DropColumn(
                name: "BillingProvider_FederalTaxId",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "BillingProvider_Name",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "BillingProvider_NpiNumber",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "BillingProvider_Phone",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "Insured_FirstName",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "Insured_GroupNumber",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "Insured_LastName",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "OtherInsurance_CreatedDate",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "Patient_BirthDate",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "Patient_FirstName",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "Patient_LastName",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "Patient_RelationshipToInsured",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "ServiceFacility_FederalTaxId",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "ServiceFacility_Name",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "ServiceFacility_NpiNumber",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "ServiceFacility_Phone",
                table: "Medical_Claim");

            migrationBuilder.RenameColumn(
                name: "Patient_Sex",
                table: "Medical_Claim",
                newName: "ConditionRelated_ConditionRelatedId");

            migrationBuilder.CreateTable(
                name: "Medical_Claim_Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
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
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GroupNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RelationshipToInsured = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false)
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
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    FederalTaxId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                name: "IX_InsuredInfo_AddressId",
                table: "InsuredInfo",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientInfo_AddressId",
                table: "PatientInfo",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderInfo_AddressId",
                table: "ProviderInfo",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_InsuredInfo_InsuredId",
                table: "Medical_Claim",
                column: "InsuredId",
                principalTable: "InsuredInfo",
                principalColumn: "InsuredInfoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_PatientInfo_PatientId",
                table: "Medical_Claim",
                column: "PatientId",
                principalTable: "PatientInfo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_ProviderInfo_BillingProviderId",
                table: "Medical_Claim",
                column: "BillingProviderId",
                principalTable: "ProviderInfo",
                principalColumn: "ProviderInfoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_ProviderInfo_ServiceFacilityId",
                table: "Medical_Claim",
                column: "ServiceFacilityId",
                principalTable: "ProviderInfo",
                principalColumn: "ProviderInfoId",
                onDelete: ReferentialAction.Restrict);

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
