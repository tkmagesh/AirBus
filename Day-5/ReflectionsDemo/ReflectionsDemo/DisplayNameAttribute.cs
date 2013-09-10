using System;

namespace ReflectionsDemo
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = false)]
    public class DisplayNameAttribute : Attribute
    {
        private readonly string _name;
        public DisplayNameAttribute(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}