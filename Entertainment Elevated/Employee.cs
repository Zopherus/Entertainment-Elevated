using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Entertainment_Elevated
{
    
    public class Employee : Person
    {
        // Set display names for the DataGridView
        
        [DisplayName("Position")]
        public string Position { get;  set; }

        [DisplayName("Payrate")]
        public decimal Payrate { get; set; }
        
        public List<Shift> Shifts { get; set; }
        

        public Employee()
        {
            Shifts = new List<Shift>();
        }

        public Employee(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            Shifts = new List<Shift>();
        }

        public Employee(string FirstName, string LastName, string PhoneNumber, string Email, string Position, decimal Payrate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Position = Position;
            this.Payrate = Payrate;
            Shifts = new List<Shift>();
        }
    }
}
