using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void GetListOfEmployes(List<Employee> employees, Program.isPromoted promoted)
        {
            foreach(Employee emp in employees)
            {
                if (promoted(emp))
                {
                    Console.WriteLine(emp.Name + " is Promoted");
                }
            }
        } 
    }
}
