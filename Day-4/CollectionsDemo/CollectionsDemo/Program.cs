using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            Dictionary<int,string> someList = new Dictionary<int, string>();
            someList.Add(1,"value - 1");
            someList.Add(2, "value - 2");
            someList.Add(3, "value - 3");
            someList.Add(4, "value - 4");
            foreach (var item in someList)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            Console.WriteLine("Value of Item with key = 2 is {0}", someList[2]);
            Console.WriteLine("Attempting to add a duplicate item");
            try
            {
                someList.Add(2, "something else");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Dont try to add a duplicate item");
            }
            Console.WriteLine("Is item with key 3 exists - {0}", someList.ContainsKey(3));
            Console.ReadLine();
        }
    }
}
