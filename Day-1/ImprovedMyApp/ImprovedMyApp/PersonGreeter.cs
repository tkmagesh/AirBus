using System;

namespace ImprovedMyApp
{
    public class PersonGreeter
    {
        private string GetGreetTemplate(int timeRangeOfDay)
        {
            switch (timeRangeOfDay)
            {
                case 2:
                    return "Good Morning";
                case 3:
                    return "Good Afternoon";
                case 4:
                    return "Good Evening";
                case 5:
                case 1:
                    return "Good Night";
                default:
                    Console.WriteLine("Unknown hour.. You must be in Mars!!!");
                    return "";
            }
        }
        public void Greet(PersonInfo person)
        {
            int hour = DateTime.Now.Hour ;
            int timeRangeOfDay = (hour / 6) + 1;
            Console.WriteLine("Hour = {0}", hour);
            Console.WriteLine(GetGreetTemplate(timeRangeOfDay) + " " + person.GetFullName());
            Console.WriteLine();
        }
    }
}