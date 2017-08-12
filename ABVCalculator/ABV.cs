using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABVCalculator
{
    public class ABV
    {
        public ABV()
        {

        }
        public double Original { get; set; }
        public double Final { get; set; }

        public double CalculateABV()
        {
            return ((Original - Final) * 131.25);
        }
    }
}
