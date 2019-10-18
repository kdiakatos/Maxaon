using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer.Models
{
    public class VisitViewModel
    {
        public int VisitId { get; set; }

        public int BiochemicalResultId { get; set; }

        public int BloodResultId { get; set; }

        public long? UserId { get; set; }

        public decimal Amount { get; set; }
    }
}
