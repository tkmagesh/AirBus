using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator calculator = new SalaryCalculator();
            
            
            calculator.Basic = 20000;
            calculator.Hra = 10000;
            calculator.Da = 5000;
            calculator.Tax = 10;
            calculator.Calculate();

            Console.WriteLine(calculator.Salary);
            Console.ReadLine();
        }
    }
}
