using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImprovedMyApp
{
    public class PersonInfo
    {
        private string _firstName;
        private string _lastName;

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }
        public string GetFirstName()
        {
            return _firstName;
        }

        
        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }
        public string GetLastName()
        {
            return _lastName;
        }

        public string GetFullName()
        {
            return _lastName + ", " + _firstName;
        }
    }
}
