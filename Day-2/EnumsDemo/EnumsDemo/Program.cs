using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumsDemo
{
    public enum GenderEnum
    {
        Male = 1,
        Female = 2
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenderEnum Gender { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            string input = Console.ReadLine();
            if (String.Compare(input, "y", StringComparison.OrdinalIgnoreCase) == 0)
            {
                Console.WriteLine("User agreed");
            }
            else
            {
                Console.WriteLine("User didnt agree");
            }
            Console.ReadLine();
        }
    }
}
