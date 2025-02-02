using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range
    {
        public int min { get; set; }
        public int max { get; set; }

        public Range(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
    }
}
