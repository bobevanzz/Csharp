using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpRedux
{

    class Employee: Person //colon and then the class type to inherit 
    {
        public int EmployeeID { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public decimal HourlyRate { get; set; }
        public bool Manager { get; set; }
        public DateTime BirthDate { get; set; }
        public string GetBirthDay()
        {
            //code goes here
            return "01/01/2018";
        }
    }
    class Person { 
        public int PersonID{ get; set; } // prop tab tab for a shortcut
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Street, City and Zip
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        private string myStatus;
        public string Status

        {
            get { return myStatus; }
            set {
                if (value.Length>2)
                {
                    throw new Exception("Bad User!");
                }
                myStatus = value;
            }
        }

        public string Phone { get; set; }
        public string Cell { get; set; }

        public string GetFullName()
        {
            return LastName + ", " + FirstName; 
        }

    }
}
