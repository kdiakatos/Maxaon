using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class BloodExaminationViewModel
    {
        public BloodExaminationViewModel()
        {

        }

        public BloodExaminationViewModel(long AMKA, DateTime date, float rbc, float hgb, float hct, float mcv, float mch, float mchc,
            float rdw_cv, float wbc, float neut, float lym)
        {
            UserId = AMKA;
            Date = date;
            RBC = rbc;
            HGB = hgb;
            HCT = hct;
            MCV = mcv;
            MCH = mch;
            MCHC = mchc;
            RDW_CV = rdw_cv;
            WBC = wbc;
            NEUT = neut;
            LYM = lym;
        }


        [Key]

        public int BloodResultId { get; set; }

        //[ForeignKey("ApplicationUser")]
        //[Required]
        public long? UserId { get; set; }

        //public virtual ApplicationUser ApplicationUser { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public float RBC { get; set; }
        public float HGB { get; set; }
        public float HCT { get; set; }
        public float MCV { get; set; }
        public float MCH { get; set; }
        public float MCHC { get; set; }
        public float RDW_CV { get; set; }
        public float WBC { get; set; }
        public float NEUT { get; set; }
        public float LYM { get; set; }
    }
}
