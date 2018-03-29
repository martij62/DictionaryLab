using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Id { get; set; }

        public override string ToString()
        {
            return Id.ToString() + ": " + FirstName + " " + LastName;
        }
    }
}
