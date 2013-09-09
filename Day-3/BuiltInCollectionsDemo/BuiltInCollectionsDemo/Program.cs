using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BuiltInCollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            
            for (var i = 1; i <= 10; i++)
                list.Add(i*10);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
