using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class BloodExamination
    {


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
