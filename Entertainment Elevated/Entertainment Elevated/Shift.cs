using System;

namespace Entertainment_Elevated
{
    // Inherit from the store visit as a shift is a form of visiting the store
    public class Shift : StoreVisit
    {
        // Inherit empty constructor from the parent class
        public Shift() : base()
        { }

        public Shift(DateTime StartTime, DateTime EndTime) : base(StartTime, EndTime)
        { }

        //  Calculate the total pay of the shift by using the base NumberHours method
        public decimal Pay(decimal payrate)
        {
            return NumberHours() * payrate;
        }
    }
}
