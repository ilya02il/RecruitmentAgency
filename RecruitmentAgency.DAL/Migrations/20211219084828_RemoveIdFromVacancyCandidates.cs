using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitmentAgency.DAL.Migrations
{
    public partial class RemoveIdFromVacancyCandidates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "VacancyCandidates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "VacancyCandidates",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
