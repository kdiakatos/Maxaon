using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BiochemicalExaminations",
                columns: table => new
                {
                    BiochemicalResultId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Glu = table.Column<float>(nullable: false),
                    UA = table.Column<float>(nullable: false),
                    CRE = table.Column<float>(nullable: false),
                    CHOL = table.Column<float>(nullable: false),
                    TRIG = table.Column<float>(nullable: false),
                    HDL_C = table.Column<float>(nullable: false),
                    LDL_C = table.Column<float>(nullable: false),
                    AST = table.Column<float>(nullable: false),
                    ALT = table.Column<float>(nullable: false),
                    GGT = table.Column<float>(nullable: false),
                    Fe = table.Column<float>(nullable: false),
                    LDH = table.Column<float>(nullable: false),
                    Ca = table.Column<float>(nullable: false),
                    K = table.Column<float>(nullable: false),
                    Na = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiochemicalExaminations", x => x.BiochemicalResultId);
                });

            migrationBuilder.CreateTable(
                name: "BloodExaminations",
                columns: table => new
                {
                    BloodResultId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    RBC = table.Column<float>(nullable: false),
                    HGB = table.Column<float>(nullable: false),
                    HCT = table.Column<float>(nullable: false),
                    MCV = table.Column<float>(nullable: false),
                    MCH = table.Column<float>(nullable: false),
                    MCHC = table.Column<float>(nullable: false),
                    RDW_CV = table.Column<float>(nullable: false),
                    WBC = table.Column<float>(nullable: false),
                    NEUT = table.Column<float>(nullable: false),
                    LYM = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodExaminations", x => x.BloodResultId);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BiochemicalResultId = table.Column<int>(nullable: false),
                    BloodResultId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AMKA = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    DateofBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "BiochemicalExaminations",
                columns: new[] { "BiochemicalResultId", "ALT", "AST", "CHOL", "CRE", "Ca", "Date", "Fe", "GGT", "Glu", "HDL_C", "K", "LDH", "LDL_C", "Na", "TRIG", "UA", "UserId" },
                values: new object[,]
                {
                    { 1, 61f, 37.1f, 67f, 1.27f, 7.46f, new DateTime(2018, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 110f, 68f, 83f, 18.2f, 2.69f, 258f, 48.5f, 92.8f, 107f, 3.88f, 23068500000L },
                    { 2, 65f, 36.2f, 63f, 1.3f, 7.45f, new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 105f, 59f, 83f, 17.2f, 2.7f, 246f, 48f, 92.8f, 101f, 3.9f, 23068500000L },
                    { 3, 66f, 38.1f, 69f, 1.18f, 7.32f, new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 114f, 67f, 85f, 18.9f, 2.54f, 249f, 46.5f, 90.6f, 101f, 3.9f, 23068500000L },
                    { 4, 68f, 37.6f, 64f, 1.37f, 7.05f, new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 120f, 61f, 83f, 15.2f, 2.55f, 262f, 49.5f, 92.7f, 117f, 3.78f, 23068500000L },
                    { 5, 69f, 34.1f, 69f, 1.27f, 7.32f, new DateTime(2018, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 111f, 64f, 91f, 17.2f, 2.54f, 265f, 50.5f, 92f, 116f, 4.58f, 13018000000L },
                    { 6, 72f, 36.3f, 69.1f, 1.32f, 7.31f, new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 102f, 59f, 93f, 16.26f, 2.42f, 267f, 51.5f, 99f, 110f, 4.61f, 13018000000L },
                    { 7, 71f, 33.6f, 72f, 1.31f, 7.92f, new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 113f, 68f, 98f, 14.2f, 2.43f, 259f, 56.5f, 98f, 103f, 4.61f, 13018000000L },
                    { 8, 71f, 33.1f, 71f, 1.17f, 7.69f, new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 103f, 61f, 85f, 18.2f, 2.49f, 267f, 53.5f, 92f, 116f, 3.88f, 13018000000L }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "AMKA", "DateofBirth", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, 23068500000L, new DateTime(1985, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "kostas@gmail.gr", "Konstantinos Diakatos", "696969" },
                    { 2, 13018000000L, new DateTime(1980, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "soza@gmail.gr", "Sotos Zarpas", "696969" },
                    { 3, 29118200000L, new DateTime(1982, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "makis@gmail.gr", "makis diakatos", "696969" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiochemicalExaminations");

            migrationBuilder.DropTable(
                name: "BloodExaminations");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
