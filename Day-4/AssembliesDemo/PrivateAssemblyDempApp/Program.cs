using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirBusUtilities;

namespace PrivateAssemblyDempApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(10,20));
            Console.ReadLine();
        }
    }
}
