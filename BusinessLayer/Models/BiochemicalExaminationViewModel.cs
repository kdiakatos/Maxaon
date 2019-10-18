using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class BiochemicalExaminationViewModel
    {
        public BiochemicalExaminationViewModel()
        {

        }

        public BiochemicalExaminationViewModel(long AMKA, DateTime date, float glu, float ua, float cre, float chol, float trig, float hdl_c,
            float ldl_c, float ast, float alt, float ggt, float fe, float ldh, float ca,
            float k, float na)
        {
            UserId = AMKA;
            Date = date;
            Glu = glu;
            UA = ua;
            CRE = cre;
            CHOL = chol;
            TRIG = trig;
            HDL_C = hdl_c;
            LDL_C = ldl_c;
            AST = ast;
            ALT = alt;
            GGT = ggt;
            Fe = fe;
            LDH = ldh;
            Ca = ca;
            K = k;
            Na = na;
        }

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
