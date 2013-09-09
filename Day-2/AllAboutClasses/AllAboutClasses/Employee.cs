using System;

namespace AllAboutClasses
{
    public class Employee
    {
        
        /*private int _Id;
        public int Id
        {
            get { return _Id; }
        }*/

        public Employee(int id)
        {
            Console.WriteLine("A new employee is being created with id = {0}",id);
            //_Id = id;
            Id = id;
        }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        //public int Id { private set; get; }

        private int _id;
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }
    }
}