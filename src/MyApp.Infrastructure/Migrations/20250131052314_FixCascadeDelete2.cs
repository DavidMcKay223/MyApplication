using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixCascadeDelete2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_PatientInfo_PatientId",
                table: "Medical_Claim");

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_PatientInfo_PatientId",
                table: "Medical_Claim",
                column: "PatientId",
                principalTable: "PatientInfo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medical_Claim_PatientInfo_PatientId",
                table: "Medical_Claim");

            migrationBuilder.AddForeignKey(
                name: "FK_Medical_Claim_PatientInfo_PatientId",
                table: "Medical_Claim",
                column: "PatientId",
                principalTable: "PatientInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
