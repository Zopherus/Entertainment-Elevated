using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Elevated
{
    public class Shift : StoreVisit
    {
        public Shift() :base()
        { }

        public Shift(DateTime StartTime, DateTime EndTime) : base(StartTime, EndTime)
        { }

        public decimal Pay(decimal payrate)
        {
            return NumberHours() * payrate;
        }
    }
}
