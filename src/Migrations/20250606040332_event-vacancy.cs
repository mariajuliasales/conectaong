using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace conectaOng.Migrations
{
    /// <inheritdoc />
    public partial class eventvacancy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "VacancyId",
                table: "Vacancy",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacancy_VacancyId",
                table: "Vacancy",
                column: "VacancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_Vacancy_VacancyId",
                table: "Vacancy",
                column: "VacancyId",
                principalTable: "Vacancy",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_Vacancy_VacancyId",
                table: "Vacancy");

            migrationBuilder.DropIndex(
                name: "IX_Vacancy_VacancyId",
                table: "Vacancy");

            migrationBuilder.DropColumn(
                name: "VacancyId",
                table: "Vacancy");
        }
    }
}
