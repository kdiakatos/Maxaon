using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class dunnyData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BloodExaminations",
                columns: new[] { "BloodResultId", "Date", "HCT", "HGB", "LYM", "MCH", "MCHC", "MCV", "NEUT", "RBC", "RDW_CV", "UserId", "WBC" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38f, 14f, 32f, 28.8f, 33f, 94f, 52f, 4.4f, 13.1f, 23068500000L, 7.2f },
                    { 2, new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 37f, 13.1f, 33f, 27.8f, 31.2f, 92f, 51f, 4.5f, 14.1f, 23068500000L, 7.3f },
                    { 3, new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 32f, 16f, 31f, 25.8f, 36f, 96f, 55f, 4.1f, 13.9f, 23068500000L, 7.1f },
                    { 4, new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 37f, 13f, 34f, 25.8f, 34f, 93f, 51f, 4.4f, 13.6f, 23068500000L, 7.6f },
                    { 5, new DateTime(2018, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 29f, 19f, 36f, 31.8f, 43f, 101f, 49f, 5.1f, 12.1f, 13018000000L, 7.7f },
                    { 6, new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 39f, 21f, 39f, 27.8f, 38f, 89f, 49f, 3.4f, 11.9f, 13018000000L, 7.4f },
                    { 7, new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 32f, 28f, 42f, 23.8f, 39f, 79f, 42f, 4.1f, 13.9f, 13018000000L, 6.4f },
                    { 8, new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.6f, 29f, 36f, 26.8f, 31f, 78f, 47f, 4.2f, 13.2f, 13018000000L, 6.9f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BloodExaminations",
                keyColumn: "BloodResultId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BloodExaminations",
                keyColumn: "BloodResultId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BloodExaminations",
                keyColumn: "BloodResultId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BloodExaminations",
                keyColumn: "BloodResultId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BloodExaminations",
                keyColumn: "BloodResultId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BloodExaminations",
                keyColumn: "BloodResultId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BloodExaminations",
                keyColumn: "BloodResultId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BloodExaminations",
                keyColumn: "BloodResultId",
                keyValue: 8);
        }
    }
}
