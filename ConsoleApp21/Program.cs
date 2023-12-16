using System;
using System.Linq;

namespace ConsoleApp21
{
    class Department
    {
        public string DepartmentName { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return $"Department name is {DepartmentName}";
        }
    }

    class Employee
    {
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }


        public override string ToString()
        {
            return $"Department name is {EmployeeName}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
                new Department(){DepartmentName = "IT", ID = 1},
                new Department() { DepartmentName = "HR", ID = 2 }
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmployeeName = "Giorgi", Age = 30, EmployeeID = 1, DepartmentID = 1},
                new Employee(){EmployeeName = "Mari", Age = 31, EmployeeID = 2, DepartmentID = 1},
                new Employee(){EmployeeName = "Lasha", Age = 30, EmployeeID = 3, DepartmentID = 2}
            };

            var groupedEmployees = from emp in employees
                                   group emp by emp.Age into groupAge
                                   select groupAge;

            foreach(var grouping in groupedEmployees)
            {
                Console.WriteLine($"Employees with age of: {grouping.Key}");
                foreach(var employeeofAge in grouping)
                {
                    Console.WriteLine("\t" + employeeofAge);
                }
            }
        }
    }
}