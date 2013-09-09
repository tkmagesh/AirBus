using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AllAboutClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor is a function which is invoked whenever new instance of a class
            // is created
            Employee employee = new Employee(101, "Magesh", "K");
            Console.WriteLine(employee.FullName);
            Console.ReadLine();
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(110.10,210.11 ));

            Console.WriteLine();
        }

        
    }
}
