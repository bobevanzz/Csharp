using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpRedux
{
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
