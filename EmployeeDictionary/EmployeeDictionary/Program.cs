﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Dictionary<int, Employee>();

            employees.Add(101, new Employee { Id=101, FirstName="Jesse", LastName = "Martin"});
            employees.Add(102, new Employee { Id = 102, FirstName = "George", LastName = "Washingotn" });
            employees.Add(103, new Employee { Id = 103, FirstName = "Smith", LastName = "Mark" });

            Console.WriteLine(employees[101]);
            Console.WriteLine(employees[102]);
            Console.WriteLine(employees[103]);
            Console.ReadLine();
        }
    }
}
