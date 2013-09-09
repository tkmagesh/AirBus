using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueAndReferenceTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Make = "maruti";
            c.Year = 2006;
            c.Color = "gray";

            Car d = c;
            d.Color = "Red";

            Console.WriteLine("Car d");
            Console.WriteLine(d);
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Car c");
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }

    struct Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        
        public override string ToString()
        {
            return string.Format("Car by {0} in {1} with {2} color", Make, Year, Color);
        }
        
    }
}
