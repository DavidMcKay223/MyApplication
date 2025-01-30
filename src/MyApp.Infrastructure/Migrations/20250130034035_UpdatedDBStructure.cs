using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastructure.Migrations
{
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
}
