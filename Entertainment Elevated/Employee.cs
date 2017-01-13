using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Entertainment_Elevated
{
    
    public class Employee
    {
        // Set display names for the DataGridView
        [DisplayName("First Name")]
        public string FirstName { get;  set; }
        
        [DisplayName("Last Name")]
        public string LastName { get;  set; }
        
        [DisplayName("Phone Number")]
        public string PhoneNumber { get;  set; }
        
        [DisplayName("Email")]
        public string Email { get;  set; }
        
        [DisplayName("Position")]
        public string Position { get;  set; }
        
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

        public Employee(string FirstName, string LastName, string PhoneNumber, string Email, string Position)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Position = Position;
            Shifts = new List<Shift>();
        }

        public string GetName()
        {
            return FirstName + " " + LastName;
        }
    }
}
