using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace SerializationDemo
{
    [Serializable]
    public class Employee
    {
        [XmlAttribute]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        [XmlElement(ElementName = "DepartmentNumber")]
        public int DeptNo { get; set; }
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}", Id, FirstName, LastName, Salary, DeptNo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Binary Serialization
            /*var employee = new Employee() {Id = 101, FirstName = "Magesh", LastName = "Kuppan", Salary = 10000, DeptNo = 10};
            var formatter = new BinaryFormatter();
            FileStream fileStream = File.Create("employee.dat");
            formatter.Serialize(fileStream,employee);
            fileStream.Close();*/

            //Binary Deserialization
            /*var formatter = new BinaryFormatter();
            FileStream fileStream = File.OpenRead("employee.dat");
            var employee = (Employee) formatter.Deserialize(fileStream);
            Console.WriteLine(employee);*/

            //Xml Serialization
            var serializer = new XmlSerializer(typeof(Employee));
            var employee = new Employee() { Id = 101, FirstName = "Magesh", LastName = "Kuppan", Salary = 10000, DeptNo = 10 };
            var writer = new StreamWriter("employee.xml");
            serializer.Serialize(writer,employee);
            writer.Close();

            //Xml Deserialization
            /*var serializer = new XmlSerializer(typeof (Employee));
            var reader = new StreamReader("employee.xml");
            var employee = (Employee) serializer.Deserialize(reader);
            Console.WriteLine(employee);*/
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
