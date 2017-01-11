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
        public string firstName { get; private set; }

        [System.ComponentModel.DisplayName("Last Name")]
        public string lastName { get; private set; }

        [System.ComponentModel.DisplayName("Cell Phone")]
        public string cellPhone { get; private set; }

        [System.ComponentModel.DisplayName("Email")]
        public string email { get; private set; }
        

        public Employee(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public Employee(string FirstName, string LastName, string CellPhone, string Email)
        {
            firstName = FirstName;
            lastName = LastName;
            cellPhone = CellPhone;
            email = Email;
        }
    }
}
