using System;
using System.Collections.Generic;

namespace Entertainment_Elevated
{
    public class Customer : Person
    {
        public List<StoreVisit> StoreVisits = new List<StoreVisit>();

        public Customer() : base()
        {
        }

        public Customer(string FirstName, string LastName, string Email, string PhoneNumber) : base(FirstName, LastName, Email, PhoneNumber)
        {
        }
    }
}
