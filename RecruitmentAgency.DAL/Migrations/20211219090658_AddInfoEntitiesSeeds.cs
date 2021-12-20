using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitmentAgency.DAL.Migrations
{
    public partial class AddInfoEntitiesSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CandidatesInfo",
                columns: new[] { "Id", "DateOfBorn", "Initials", "UserId" },
                values: new object[] { 1, new DateTime(2021, 12, 19, 16, 6, 58, 113, DateTimeKind.Local).AddTicks(3356), "Иванов Иван Иванович", 3 });

            migrationBuilder.InsertData(
                table: "EmployersInfo",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { 1, "Трудовичок", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CandidatesInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployersInfo",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
