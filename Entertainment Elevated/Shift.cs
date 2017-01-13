using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Elevated
{
    public class Shift
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Shift() { }

        public Shift(DateTime StartTime, DateTime EndTime)
        {
            this.StartTime = StartTime;
            this.EndTime = EndTime;
        }

        public decimal NumberHours()
        {
            return EndTime.Subtract(StartTime).Hours;
        }
    }
}
