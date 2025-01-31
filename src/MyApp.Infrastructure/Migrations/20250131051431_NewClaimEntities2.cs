using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewClaimEntities2 : Migration
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
                name: "FK_Medical_Claim_Diagnosis_Medical_Claim_ClaimId",
                table: "Medical_Claim_Diagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_ServiceLine_Medical_Claim_ClaimId",
                table: "Medical_Claim_ServiceLine");

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Medical_Claim_Diagnosis_Medical_Claim_ClaimId",
                table: "Medical_Claim_Diagnosis",
                column: "ClaimId",
                principalTable: "Medical_Claim",
                principalColumn: "FormId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_ServiceLine_Medical_Claim_ClaimId",
                table: "Medical_Claim_ServiceLine",
                column: "ClaimId",
                principalTable: "Medical_Claim",
                principalColumn: "FormId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_Medical_Claim_Diagnosis_Medical_Claim_ClaimId",
                table: "Medical_Claim_Diagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_ServiceLine_Medical_Claim_ClaimId",
                table: "Medical_Claim_ServiceLine");

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_InsuredInfo_InsuredId",
                table: "Medical_Claim",
                column: "InsuredId",
                principalTable: "InsuredInfo",
                principalColumn: "InsuredInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_PatientInfo_PatientId",
                table: "Medical_Claim",
                column: "PatientId",
                principalTable: "PatientInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_ProviderInfo_BillingProviderId",
                table: "Medical_Claim",
                column: "BillingProviderId",
                principalTable: "ProviderInfo",
                principalColumn: "ProviderInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_ProviderInfo_ServiceFacilityId",
                table: "Medical_Claim",
                column: "ServiceFacilityId",
                principalTable: "ProviderInfo",
                principalColumn: "ProviderInfoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_Diagnosis_Medical_Claim_ClaimId",
                table: "Medical_Claim_Diagnosis",
                column: "ClaimId",
                principalTable: "Medical_Claim",
                principalColumn: "FormId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_ServiceLine_Medical_Claim_ClaimId",
                table: "Medical_Claim_ServiceLine",
                column: "ClaimId",
                principalTable: "Medical_Claim",
                principalColumn: "FormId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
