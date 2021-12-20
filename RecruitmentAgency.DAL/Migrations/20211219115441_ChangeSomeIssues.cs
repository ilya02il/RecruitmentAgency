using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitmentAgency.DAL.Migrations
{
    public partial class ChangeSomeIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBorn",
                table: "CandidatesInfo",
                newName: "DateOfBirth");

            migrationBuilder.UpdateData(
                table: "CandidatesInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 19, 18, 54, 40, 990, DateTimeKind.Local).AddTicks(7144));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "CandidatesInfo",
                newName: "DateOfBorn");

            migrationBuilder.UpdateData(
                table: "CandidatesInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBorn",
                value: new DateTime(2021, 12, 19, 16, 6, 58, 113, DateTimeKind.Local).AddTicks(3356));
        }
    }
}
