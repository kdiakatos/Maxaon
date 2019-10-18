using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Services
{
    public class CalculationService
    {
        public float Average(List<float> data)
        {
            var aver = data.Average();
            return aver;
        }
    }
}
