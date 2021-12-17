using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitmentAgency.DAL.Migrations
{
    public partial class RemovePositionAndSalaryFromCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "CandidatesInfo");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "CandidatesInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "CandidatesInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "CandidatesInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
