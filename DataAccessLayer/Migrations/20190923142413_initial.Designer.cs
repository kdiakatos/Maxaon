﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(MDTContext))]
    [Migration("20190923142413_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccessLayer.Entities.BiochemicalExamination", b =>
                {
                    b.Property<int>("BiochemicalResultId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("ALT");

                    b.Property<float>("AST");

                    b.Property<float>("CHOL");

                    b.Property<float>("CRE");

                    b.Property<float>("Ca");

                    b.Property<DateTime>("Date");

                    b.Property<float>("Fe");

                    b.Property<float>("GGT");

                    b.Property<float>("Glu");

                    b.Property<float>("HDL_C");

                    b.Property<float>("K");

                    b.Property<float>("LDH");

                    b.Property<float>("LDL_C");

                    b.Property<float>("Na");

                    b.Property<float>("TRIG");

                    b.Property<float>("UA");

                    b.Property<long?>("UserId");

                    b.HasKey("BiochemicalResultId");

                    b.ToTable("BiochemicalExaminations");

                    b.HasData(
                        new
                        {
                            BiochemicalResultId = 1,
                            ALT = 61f,
                            AST = 37.1f,
                            CHOL = 67f,
                            CRE = 1.27f,
                            Ca = 7.46f,
                            Date = new DateTime(2018, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fe = 110f,
                            GGT = 68f,
                            Glu = 83f,
                            HDL_C = 18.2f,
                            K = 2.69f,
                            LDH = 258f,
                            LDL_C = 48.5f,
                            Na = 92.8f,
                            TRIG = 107f,
                            UA = 3.88f,
                            UserId = 23068500000L
                        },
                        new
                        {
                            BiochemicalResultId = 2,
                            ALT = 65f,
                            AST = 36.2f,
                            CHOL = 63f,
                            CRE = 1.3f,
                            Ca = 7.45f,
                            Date = new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fe = 105f,
                            GGT = 59f,
                            Glu = 83f,
                            HDL_C = 17.2f,
                            K = 2.7f,
                            LDH = 246f,
                            LDL_C = 48f,
                            Na = 92.8f,
                            TRIG = 101f,
                            UA = 3.9f,
                            UserId = 23068500000L
                        },
                        new
                        {
                            BiochemicalResultId = 3,
                            ALT = 66f,
                            AST = 38.1f,
                            CHOL = 69f,
                            CRE = 1.18f,
                            Ca = 7.32f,
                            Date = new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fe = 114f,
                            GGT = 67f,
                            Glu = 85f,
                            HDL_C = 18.9f,
                            K = 2.54f,
                            LDH = 249f,
                            LDL_C = 46.5f,
                            Na = 90.6f,
                            TRIG = 101f,
                            UA = 3.9f,
                            UserId = 23068500000L
                        },
                        new
                        {
                            BiochemicalResultId = 4,
                            ALT = 68f,
                            AST = 37.6f,
                            CHOL = 64f,
                            CRE = 1.37f,
                            Ca = 7.05f,
                            Date = new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fe = 120f,
                            GGT = 61f,
                            Glu = 83f,
                            HDL_C = 15.2f,
                            K = 2.55f,
                            LDH = 262f,
                            LDL_C = 49.5f,
                            Na = 92.7f,
                            TRIG = 117f,
                            UA = 3.78f,
                            UserId = 23068500000L
                        },
                        new
                        {
                            BiochemicalResultId = 5,
                            ALT = 69f,
                            AST = 34.1f,
                            CHOL = 69f,
                            CRE = 1.27f,
                            Ca = 7.32f,
                            Date = new DateTime(2018, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fe = 111f,
                            GGT = 64f,
                            Glu = 91f,
                            HDL_C = 17.2f,
                            K = 2.54f,
                            LDH = 265f,
                            LDL_C = 50.5f,
                            Na = 92f,
                            TRIG = 116f,
                            UA = 4.58f,
                            UserId = 13018000000L
                        },
                        new
                        {
                            BiochemicalResultId = 6,
                            ALT = 72f,
                            AST = 36.3f,
                            CHOL = 69.1f,
                            CRE = 1.32f,
                            Ca = 7.31f,
                            Date = new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fe = 102f,
                            GGT = 59f,
                            Glu = 93f,
                            HDL_C = 16.26f,
                            K = 2.42f,
                            LDH = 267f,
                            LDL_C = 51.5f,
                            Na = 99f,
                            TRIG = 110f,
                            UA = 4.61f,
                            UserId = 13018000000L
                        },
                        new
                        {
                            BiochemicalResultId = 7,
                            ALT = 71f,
                            AST = 33.6f,
                            CHOL = 72f,
                            CRE = 1.31f,
                            Ca = 7.92f,
                            Date = new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fe = 113f,
                            GGT = 68f,
                            Glu = 98f,
                            HDL_C = 14.2f,
                            K = 2.43f,
                            LDH = 259f,
                            LDL_C = 56.5f,
                            Na = 98f,
                            TRIG = 103f,
                            UA = 4.61f,
                            UserId = 13018000000L
                        },
                        new
                        {
                            BiochemicalResultId = 8,
                            ALT = 71f,
                            AST = 33.1f,
                            CHOL = 71f,
                            CRE = 1.17f,
                            Ca = 7.69f,
                            Date = new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fe = 103f,
                            GGT = 61f,
                            Glu = 85f,
                            HDL_C = 18.2f,
                            K = 2.49f,
                            LDH = 267f,
                            LDL_C = 53.5f,
                            Na = 92f,
                            TRIG = 116f,
                            UA = 3.88f,
                            UserId = 13018000000L
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Entities.BloodExamination", b =>
                {
                    b.Property<int>("BloodResultId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<float>("HCT");

                    b.Property<float>("HGB");

                    b.Property<float>("LYM");

                    b.Property<float>("MCH");

                    b.Property<float>("MCHC");

                    b.Property<float>("MCV");

                    b.Property<float>("NEUT");

                    b.Property<float>("RBC");

                    b.Property<float>("RDW_CV");

                    b.Property<long?>("UserId");

                    b.Property<float>("WBC");

                    b.HasKey("BloodResultId");

                    b.ToTable("BloodExaminations");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BiochemicalResultId");

                    b.Property<int>("BloodResultId");

                    b.HasKey("ID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AMKA");

                    b.Property<DateTime>("DateofBirth");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AMKA = 23068500000L,
                            DateofBirth = new DateTime(1985, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kostas@gmail.gr",
                            Name = "Konstantinos Diakatos",
                            Password = "696969"
                        },
                        new
                        {
                            ID = 2,
                            AMKA = 13018000000L,
                            DateofBirth = new DateTime(1980, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "soza@gmail.gr",
                            Name = "Sotos Zarpas",
                            Password = "696969"
                        },
                        new
                        {
                            ID = 3,
                            AMKA = 29118200000L,
                            DateofBirth = new DateTime(1982, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "makis@gmail.gr",
                            Name = "makis diakatos",
                            Password = "696969"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
