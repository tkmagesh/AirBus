using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee() {Id = 101, FirstName = "Magesh", LastName = "K", Salary = 10000};
            Console.WriteLine(MyUtilities.NameFormat(emp,"\t"));
            

            var product = new Product() {Id = 101, Name = "Pen", Cost = 100, Units = 10};
            Console.WriteLine(MyUtilities.Format(product, ","));
            Console.ReadLine();
        }
    }
}
