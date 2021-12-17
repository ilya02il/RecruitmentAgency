using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitmentAgency.DAL.Migrations
{
    public partial class EditVacancyIdProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacancyCandidates_Vacancies_VacancyId",
                table: "VacancyCandidates");

            migrationBuilder.DropColumn(
                name: "VancancyId",
                table: "VacancyCandidates");

            migrationBuilder.AlterColumn<int>(
                name: "VacancyId",
                table: "VacancyCandidates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_VacancyCandidates_Vacancies_VacancyId",
                table: "VacancyCandidates",
                column: "VacancyId",
                principalTable: "Vacancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VacancyCandidates_Vacancies_VacancyId",
                table: "VacancyCandidates");

            migrationBuilder.AlterColumn<int>(
                name: "VacancyId",
                table: "VacancyCandidates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "VancancyId",
                table: "VacancyCandidates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_VacancyCandidates_Vacancies_VacancyId",
                table: "VacancyCandidates",
                column: "VacancyId",
                principalTable: "Vacancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
