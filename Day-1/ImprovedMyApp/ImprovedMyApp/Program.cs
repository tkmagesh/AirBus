using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImprovedMyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PersonInfoCollector collector = new PersonInfoCollector();
            PersonInfo x = collector.CollectInfo();
            Console.WriteLine(x.GetFullName());

            PersonGreeter greeter = new PersonGreeter();
            greeter.Greet(x);
            Console.ReadLine();
        }
    }
}

