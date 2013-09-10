using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EmployeeManagementApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var employees = new Employees();
            while (true)
            {
                Console.WriteLine("Do you want to add an employee [y/n]?");
                var response = Console.ReadLine();
                if (String.Compare(response, "n", StringComparison.OrdinalIgnoreCase) == 0)
                    break;
                var employee = new Employee();
                Console.Write("ID = ");
                employee.Id = int.Parse(Console.ReadLine());
                Console.Write("First Name = ");
                employee.FirstName = Console.ReadLine();
                Console.Write("Last Name = ");
                employee.LastName = Console.ReadLine();
                Console.Write("Salary = ");
                employee.Salary = decimal.Parse(Console.ReadLine());
                employees.Add(employee);
            }
            while (true)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Print");
                Console.WriteLine("2. Save");
                Console.WriteLine("3. Exit");
                var choice = int.Parse(Console.ReadLine());
                if (choice == 3) break;
                switch (choice)
                {
                    case 1:
                        employees.Print();
                        break;
                    case 2:
                        employees.Save();
                        break;

                }
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        public class Employees
        {
            private List<Employee> _list = new List<Employee>();

            public void Add(Employee employee)
            {
                _list.Add(employee);
            }

            public void Save()
            {
                var writer = new StreamWriter("employees.txt");
                foreach (var employee in _list)
                {
                    writer.WriteLine(employee.Format(","));
                }
                writer.Close();
            }

            public void Print()
            {
                foreach (var employee in _list)
                {
                    Console.WriteLine(employee);
                }
            }
        }

        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal Salary { get; set; }

            public string Format(string seperator)
            {
                return string.Format("{0}{4}{1}{4}{2}{4}{3}", Id, FirstName, LastName, Salary, seperator);
            }

            public override string ToString()
            {
                return Format("\t");
            }
        }
    }
}
