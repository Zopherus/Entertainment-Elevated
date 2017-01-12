using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Entertainment_Elevated
{
    
    public class Employee
    {
        // Set display names for the DataGridView
        [DisplayName("First Name")]
        public string firstName { get;  set; }
        
        [DisplayName("Last Name")]
        public string lastName { get;  set; }
        
        [DisplayName("Phone Number")]
        public string phoneNumber { get;  set; }
        
        [DisplayName("Email")]
        public string email { get;  set; }
        
        [DisplayName("Position")]
        public string position { get;  set; }
        

        public Employee() { }

        public Employee(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public Employee(string FirstName, string LastName, string PhoneNumber, string Email, string Position)
        {
            firstName = FirstName;
            lastName = LastName;
            phoneNumber = PhoneNumber;
            email = Email;
            position = Position;
        }
    }
}
