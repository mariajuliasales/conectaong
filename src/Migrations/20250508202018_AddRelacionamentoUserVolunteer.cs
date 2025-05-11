using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conectaOng.Migrations
{
    /// <inheritdoc />
    public partial class AddRelacionamentoUserVolunteer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Volunteer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Volunteer_UserId",
                table: "Volunteer",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Volunteer_User_UserId",
                table: "Volunteer",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Volunteer_User_UserId",
                table: "Volunteer");

            migrationBuilder.DropIndex(
                name: "IX_Volunteer_UserId",
                table: "Volunteer");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Volunteer");
        }
    }
}
