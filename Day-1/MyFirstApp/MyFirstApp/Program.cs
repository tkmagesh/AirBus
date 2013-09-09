using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.DarkRed; 
            Console.Write("Enter your first name :");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name :");
            string lastName = Console.ReadLine(); 
            //Console.Write("Enter the hour :");
            //string hourInString = Console.ReadLine();
            //int hour = int.Parse(hourInString);
            /*int hour = DateTime.Now.Hour ;*/
            for (int hour = 0; hour <= 24; hour = hour + 1)
            /*int hour = 0;
            while (hour <= 24)*/
            {
                int timeRangeOfDay = (hour/6) + 1;
                Console.WriteLine("Hour = {0}", hour);
                switch (timeRangeOfDay)
                {
                    case 2:
                        Console.WriteLine("Good Morning {0},{1}", lastName, firstName);
                        break;
                    case 3:
                        Console.WriteLine("Good Afternoon {0},{1}", lastName, firstName);
                        break;
                    case 4:
                        Console.WriteLine("Good Evening {0},{1}", lastName, firstName);
                        break;
                    case 5:
                    case 1:
                        Console.WriteLine("Good Night {0},{1}", lastName, firstName);
                        break;
                    default:
                        Console.WriteLine("Unknown hour.. You must be in Mars!!!");
                        break;
                }
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }
    }
}
