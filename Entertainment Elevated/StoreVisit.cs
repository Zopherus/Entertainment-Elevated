using System;

namespace Entertainment_Elevated
{
    public class StoreVisit
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public StoreVisit() { }

        public StoreVisit(DateTime StartTime)
        {
            this.StartTime = StartTime;
        }

        public StoreVisit(DateTime StartTime, DateTime EndTime)
        {
            this.StartTime = StartTime;
            this.EndTime = EndTime;
        }

        public decimal NumberHours()
        {
            TimeSpan timeSpan = EndTime.Subtract(StartTime);
            return timeSpan.Hours + timeSpan.Minutes / 60;
        }
    }
}
