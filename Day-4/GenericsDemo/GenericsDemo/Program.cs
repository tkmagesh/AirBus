using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>{10,2,7,8,1,9,6,5};

            //Using Interface - IComparer
            /*var comparisonAlgorithm = new NumberComparer();
            list.Sort(comparisonAlgorithm);*/

            //Using Delegates
            list.Sort(NumberComparison);


            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }

        public static int NumberComparison(int x, int y)
        {
            if (x < y) return 1;
            if (x == y) return 0;
            return -1;
        }
    }

    public class NumberComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x < y) return 1;
            if (x == y) return 0;
            return -1;
        }
    }
}
