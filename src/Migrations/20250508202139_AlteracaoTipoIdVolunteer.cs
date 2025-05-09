using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conectaOng.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoTipoIdVolunteer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Remove PK
            migrationBuilder.DropPrimaryKey(
                name: "Id",
                table: "Volunteer");

            // Remove coluna antiga
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Volunteer");

            // Cria nova coluna Guid com o mesmo nome
            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Volunteer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            // Adiciona nova PK
            migrationBuilder.AddPrimaryKey(
                name: "Id",
                table: "Volunteer",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
         name: "Id",
         table: "Volunteer");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Volunteer");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Volunteer",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "Id",
                table: "Volunteer",
                column: "Id");
        }
    }
}
