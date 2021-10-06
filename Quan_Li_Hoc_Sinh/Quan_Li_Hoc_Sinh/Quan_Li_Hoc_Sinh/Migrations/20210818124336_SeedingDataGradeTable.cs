using Microsoft.EntityFrameworkCore.Migrations;

namespace Quan_Li_Hoc_Sinh.Migrations
{
    public partial class SeedingDataGradeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "grades",
                columns: new[] { "GradeId", "GradeName", "IsDeleted" },
                values: new object[,]
                {
                    { 1, "lopabc", true },
                    { 2, "lopabc2", true },
                    { 3, "lopabc3", true },
                    { 4, "lopabc4", true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "GradeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "GradeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "GradeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "grades",
                keyColumn: "GradeId",
                keyValue: 4);
        }
    }
}
