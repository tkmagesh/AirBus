using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            for(var i=0;i<10;i++)
                myList.Add(i+1);
            Console.WriteLine(myList.Count);
            myList.Remove(3);

        }
    }
    class MyList
    {
        private object[] _contents = new object[10];
        private int _count;

        public void Add(object obj)
        {
            _contents[_count] = obj;
            _count++;
            if (_contents.Length == _count)
            {
                expandContents();
            }
        }
        private void expandContents()
        {
            object[] newContents = new object[_count + 10];
            _contents.CopyTo(newContents,0);
            _contents = newContents;
            
        }
        public void Remove(int index)
        {
            
        }

        public int Count
        {
            get { return _count; }
        }

        public object Get(int index)
        {
            return _contents[index];
        }
    }
}
