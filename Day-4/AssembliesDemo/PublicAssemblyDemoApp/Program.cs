using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirBusUtilities;

namespace PublicAssemblyDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(10,20));
            Console.ReadLine();
        }
    }
}
