using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Elevated
{
    public enum Positions {};
    public class Employee
    {
        public static List<string> Positions { get; private set; }

        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string cellPhone { get; private set; }
        public string email { get; private set; }
        public DateTime birthday { get; private set; }
        

        public Employee(string FirstName, string LastName, DateTime Birthday)
        {
            firstName = FirstName;
            lastName = LastName;
            birthday = Birthday;
        }


        public void AddPosition(string position)
        {
            Positions.Add(position);
        }
    }
}
