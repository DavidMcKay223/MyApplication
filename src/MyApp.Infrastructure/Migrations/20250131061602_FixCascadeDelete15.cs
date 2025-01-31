using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixCascadeDelete15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingProviderId",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "InsuredId",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Medical_Claim");

            migrationBuilder.DropColumn(
                name: "ServiceFacilityId",
                table: "Medical_Claim");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BillingProviderId",
                table: "Medical_Claim",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsuredId",
                table: "Medical_Claim",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Medical_Claim",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceFacilityId",
                table: "Medical_Claim",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
