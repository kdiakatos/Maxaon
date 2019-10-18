using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Visit
    {
        [Key]
        public int VisitId { get; set; }

        public int BiochemicalResultId { get; set; }

        public int BloodResultId { get; set; }

        public long? UserId { get; set; }

        public decimal Amount { get; set; }
    }
}
