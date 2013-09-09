using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImprovedMyApp
{
    class PersonInfoCollector
    {
       public PersonInfo CollectInfo()
       {
           PersonInfo person = new PersonInfo();

           Console.WriteLine("Enter first name");
           person.SetFirstName(Console.ReadLine());

           Console.WriteLine("Enter last name");
           person.SetLastName(Console.ReadLine());
           return person;
       }
    }
}
