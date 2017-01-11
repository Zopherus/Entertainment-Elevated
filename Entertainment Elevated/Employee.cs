using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Elevated
{
    public class Employee
    {
        // Set display names for the DataGridView
        [System.ComponentModel.DisplayName("First Name")]
        public string firstName { get;  set; }

        [System.ComponentModel.DisplayName("Last Name")]
        public string lastName { get;  set; }

        [System.ComponentModel.DisplayName("Phone Number")]
        public string phoneNumber { get;  set; }

        [System.ComponentModel.DisplayName("Email")]
        public string email { get;  set; }

        [System.ComponentModel.DisplayName("Position")]
        public string position { get;  set; }
        

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
