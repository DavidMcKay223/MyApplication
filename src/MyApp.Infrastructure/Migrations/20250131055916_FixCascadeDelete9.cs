using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixCascadeDelete9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_Diagnosis_Medical_Claim_ClaimId",
                table: "Medical_Claim_Diagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_ServiceLine_Medical_Claim_ClaimId",
                table: "Medical_Claim_ServiceLine");

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_Diagnosis_Medical_Claim_ClaimId",
                table: "Medical_Claim_Diagnosis",
                column: "ClaimId",
                principalTable: "Medical_Claim",
                principalColumn: "FormId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_ServiceLine_Medical_Claim_ClaimId",
                table: "Medical_Claim_ServiceLine",
                column: "ClaimId",
                principalTable: "Medical_Claim",
                principalColumn: "FormId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_Diagnosis_Medical_Claim_ClaimId",
                table: "Medical_Claim_Diagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_ServiceLine_Medical_Claim_ClaimId",
                table: "Medical_Claim_ServiceLine");

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
    }
}
