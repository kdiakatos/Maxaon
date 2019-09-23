using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class MDTContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-R1E4IFI\SQLEXPRESS;Initial Catalog=Maxaon;Integrated Security=True;");
        }

        public DbSet<BloodExamination> BloodExaminations { get; set; }

        public DbSet<BiochemicalExamination> BiochemicalExaminations { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    AMKA = 23068500000,
                    Name = "Konstantinos Diakatos",
                    DateofBirth = new DateTime(1985,06,23),
                    Email = "kostas@gmail.gr",
                    Password = "696969"
                },
                new User
                {
                    ID = 2,
                    AMKA = 13018000000,
                    Name = "Sotos Zarpas",
                    DateofBirth = new DateTime(1980,01,13),
                    Email = "soza@gmail.gr",
                    Password = "696969"
                },
                new User
                {
                    ID = 3,
                    AMKA = 29118200000,
                    Name = "makis diakatos",
                    DateofBirth = new DateTime(1982,11,29),
                    Email = "makis@gmail.gr",
                    Password = "696969"
                }
                );
            modelBuilder.Entity<BiochemicalExamination>().HasData(
                new BiochemicalExamination
                {
                    BiochemicalResultId=1,UserId =23068500000,Date=new DateTime(2018,1,12),Glu= 83,UA=3.88f,CRE=1.27f,CHOL=67f,TRIG=107f,HDL_C=18.2f,LDL_C=48.5f,AST=37.1f,ALT=61f,GGT=68f,Fe=110f,LDH=258f,Ca=7.46f,K=2.69f,Na=92.8f
                },
                new BiochemicalExamination
                {
                    BiochemicalResultId=2,
                    UserId = 23068500000,
                    Date = new DateTime(2018, 6, 12),
                    Glu = 83,
                    UA = 3.90f,
                    CRE = 1.3f,
                    CHOL = 63f,
                    TRIG = 101f,
                    HDL_C = 17.2f,
                    LDL_C = 48f,
                    AST = 36.2f,
                    ALT = 65f,
                    GGT = 59f,
                    Fe = 105f,
                    LDH = 246f,
                    Ca = 7.45f,
                    K = 2.7f,
                    Na = 92.8f
                },
                new BiochemicalExamination
                {
                    BiochemicalResultId=3,
                    UserId = 23068500000,
                    Date = new DateTime(2019, 1, 12),
                    Glu = 85,
                    UA = 3.9f,
                    CRE = 1.18f,
                    CHOL = 69f,
                    TRIG = 101f,
                    HDL_C = 18.9f,
                    LDL_C = 46.5f,
                    AST = 38.1f,
                    ALT = 66f,
                    GGT = 67f,
                    Fe = 114f,
                    LDH = 249f,
                    Ca = 7.32f,
                    K = 2.54f,
                    Na = 90.6f
                },
                new BiochemicalExamination
                {
                    BiochemicalResultId=4,
                    UserId = 23068500000,
                    Date = new DateTime(2018, 6, 12),
                    Glu = 83,
                    UA = 3.78f,
                    CRE = 1.37f,
                    CHOL = 64f,
                    TRIG = 117f,
                    HDL_C = 15.2f,
                    LDL_C = 49.5f,
                    AST = 37.6f,
                    ALT = 68f,
                    GGT = 61,
                    Fe = 120f,
                    LDH = 262f,
                    Ca = 7.05f,
                    K = 2.55f,
                    Na = 92.7f
                },
                new BiochemicalExamination
                {
                    BiochemicalResultId=5,
                    UserId = 13018000000,
                    Date = new DateTime(2018, 1, 12),
                    Glu = 91,
                    UA = 4.58f,
                    CRE = 1.27f,
                    CHOL = 69f,
                    TRIG = 116f,
                    HDL_C = 17.2f,
                    LDL_C = 50.5f,
                    AST = 34.1f,
                    ALT = 69f,
                    GGT = 64f,
                    Fe = 111f,
                    LDH = 265f,
                    Ca = 7.32f,
                    K = 2.54f,
                    Na = 92f
                },
                  new BiochemicalExamination
                  {
                      BiochemicalResultId=6,
                      UserId = 13018000000,
                      Date = new DateTime(2018, 6, 12),
                      Glu = 93f,
                      UA = 4.61f,
                      CRE = 1.32f,
                      CHOL = 69.1f,
                      TRIG = 110f,
                      HDL_C = 16.26f,
                      LDL_C = 51.5f,
                      AST = 36.3f,
                      ALT = 72f,
                      GGT = 59f,
                      Fe = 102f,
                      LDH = 267f,
                      Ca = 7.31f,
                      K = 2.42f,
                      Na = 99f
                  },
                    new BiochemicalExamination
                    {
                        BiochemicalResultId=7,
                        UserId = 13018000000,
                        Date = new DateTime(2019, 1, 12),
                        Glu = 98,
                        UA = 4.61f,
                        CRE = 1.31f,
                        CHOL = 72f,
                        TRIG = 103f,
                        HDL_C = 14.2f,
                        LDL_C = 56.5f,
                        AST = 33.6f,
                        ALT = 71f,
                        GGT = 68f,
                        Fe = 113f,
                        LDH = 259f,
                        Ca = 7.92f,
                        K = 2.43f,
                        Na = 98f
                    },
                      new BiochemicalExamination
                      {
                          BiochemicalResultId=8,
                          UserId = 13018000000,
                          Date = new DateTime(2019, 1, 12),
                          Glu = 85,
                          UA = 3.88f,
                          CRE = 1.17f,
                          CHOL = 71f,
                          TRIG = 116f,
                          HDL_C = 18.2f,
                          LDL_C = 53.5f,
                          AST = 33.1f,
                          ALT = 71f,
                          GGT = 61f,
                          Fe = 103f,
                          LDH = 267f,
                          Ca = 7.69f,
                          K = 2.49f,
                          Na = 92f
                      }


                );
            modelBuilder.Entity<BloodExamination>().HasData(
                new BloodExamination
                {
                    BloodResultId=1,
                    UserId=23068500000,
                    Date=new DateTime(2018,1,12),
                    RBC=4.4f,
                    HGB=14f,
                    HCT=38f,
                    MCV=94f,
                    MCH=28.8f,
                    MCHC=33f,
                    RDW_CV=13.1f,
                    WBC=7.2f,
                    NEUT=52f,
                    LYM=32f
                    
                },
                 new BloodExamination
                 {
                     BloodResultId = 2,
                     UserId = 23068500000,
                     Date = new DateTime(2018, 6, 12),
                     RBC = 4.5f,
                     HGB = 13.1f,
                     HCT = 37f,
                     MCV = 92f,
                     MCH = 27.8f,
                     MCHC = 31.2f,
                     RDW_CV = 14.1f,
                     WBC = 7.3f,
                     NEUT = 51f,
                     LYM = 33f

                 },
                  new BloodExamination
                  {
                      BloodResultId = 3,
                      UserId = 23068500000,
                      Date = new DateTime(2019, 1, 12),
                      RBC = 4.1f,
                      HGB = 16f,
                      HCT = 32f,
                      MCV = 96f,
                      MCH = 25.8f,
                      MCHC = 36f,
                      RDW_CV = 13.9f,
                      WBC = 7.1f,
                      NEUT = 55f,
                      LYM = 31f

                  },
                   new BloodExamination
                   {
                       BloodResultId = 4,
                       UserId = 23068500000,
                       Date = new DateTime(2019, 6, 12),
                       RBC = 4.4f,
                       HGB = 13f,
                       HCT = 37f,
                       MCV = 93f,
                       MCH = 25.8f,
                       MCHC = 34f,
                       RDW_CV = 13.6f,
                       WBC = 7.6f,
                       NEUT = 51f,
                       LYM = 34f

                   },
                    new BloodExamination
                    {
                        BloodResultId = 5,
                        UserId = 13018000000,
                        Date = new DateTime(2018, 1, 12),
                        RBC = 5.1f,
                        HGB = 19f,
                        HCT = 29f,
                        MCV = 101f,
                        MCH = 31.8f,
                        MCHC = 43f,
                        RDW_CV = 12.1f,
                        WBC = 7.7f,
                        NEUT = 49f,
                        LYM = 36f

                    },
                     new BloodExamination
                     {
                         BloodResultId = 6,
                         UserId = 13018000000,
                         Date = new DateTime(2018, 6, 12),
                         RBC = 3.4f,
                         HGB = 21f,
                         HCT = 39f,
                         MCV = 89f,
                         MCH = 27.8f,
                         MCHC = 38f,
                         RDW_CV = 11.9f,
                         WBC = 7.4f,
                         NEUT = 49f,
                         LYM = 39f

                     },
                     new BloodExamination
                     {
                         BloodResultId = 7,
                         UserId = 13018000000,
                         Date = new DateTime(2019, 1, 12),
                         RBC = 4.1f,
                         HGB = 28f,
                         HCT = 32f,
                         MCV = 79f,
                         MCH = 23.8f,
                         MCHC = 39f,
                         RDW_CV = 13.9f,
                         WBC = 6.4f,
                         NEUT = 42f,
                         LYM = 42f

                     },
                     new BloodExamination
                     {
                         BloodResultId = 8,
                         UserId = 13018000000,
                         Date = new DateTime(2019, 6, 12),
                         RBC = 4.2f,
                         HGB = 29f,
                         HCT = 35.6f,
                         MCV = 78f,
                         MCH = 26.8f,
                         MCHC = 31f,
                         RDW_CV = 13.2f,
                         WBC = 6.9f,
                         NEUT = 47f,
                         LYM = 36f

                     }
                );
        }
    }
}
