using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class BiochemicalExamination
    {
        [Key]

        public int BiochemicalResultId { get; set; }

        //[ForeignKey("ApplicationUser")]
        //[Required]
        public long? UserId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public float Glu { get; set; }
        public float UA { get; set; }
        public float CRE { get; set; }
        public float CHOL { get; set; }
        public float TRIG { get; set; }
        public float HDL_C { get; set; }
        public float LDL_C { get; set; }
        public float AST { get; set; }
        public float ALT { get; set; }
        public float GGT { get; set; }
        public float Fe { get; set; }
        public float LDH { get; set; }
        public float Ca { get; set; }
        public float K { get; set; }
        public float Na { get; set; }
    }
}


