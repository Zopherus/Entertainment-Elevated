using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Elevated
{
    public class Shift
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }

        public Shift() { }

        public Shift(DateTime StartTime, DateTime EndTime)
        {
            startTime = StartTime;
            endTime = EndTime;
        }
    }
}
