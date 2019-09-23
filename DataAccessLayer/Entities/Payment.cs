using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Payment
    {
        public int ID { get; set; }

        public int BiochemicalResultId { get; set; }

        public int BloodResultId { get; set; }
    }
}
