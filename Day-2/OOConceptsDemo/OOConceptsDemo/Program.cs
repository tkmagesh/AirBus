using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOConceptsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.Id = 100;
            fte.FirstName = "Magesh";
            fte.LastName = "K";
            fte.Bonus = 10000m;
            fte.Print();

            fte.Play();

            ContractEmployee cte = new ContractEmployee();
            cte.Id = 200;
            cte.FirstName = "Suresh";
            cte.LastName = "K";
            cte.ContractorName = "Some Body Shopper";
            cte.Print();

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("From employees array");
            Console.WriteLine();
            Employee[] employees = new Employee[]{fte,cte};
            for (var i = 0; i < employees.Length; i++)
            {
                employees[i].Print();
                Console.WriteLine();
            }
            Console.WriteLine();

            IPlayCricket[] cricketeres = new IPlayCricket[]
                {
                    new FullTimeEmployee(), new ContractEmployee()
                };
            for (var i = 0; i < cricketeres.Length; i++)
            {
                //cricketeres[i].
            }
                Console.WriteLine("Done");
            Console.ReadLine();

            

        }
    }

    public interface IPlayCricket
    {
        void Play();
    }

    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
       /* public virtual void Print()
        {
            Console.WriteLine("From Employee Class - Employee id ={0}, firstName={1}, lastName={2}",Id,FirstName,LastName);
        }*/

        public abstract void Print();
    }

    public class FullTimeEmployee  : Employee, IPlayCricket
    {
        public decimal Bonus { get; set; }

        public override void Print()
        {
            Console.WriteLine("From FulltimeEmployee Class - Employee id ={0}, firstName={1}, lastName={2}, Bonus={3}", Id, FirstName, LastName, Bonus);
        }

        public void Play()
        {
            Console.WriteLine("As I promised, I am playing cricket");
        }
    }

    public class ContractEmployee : Employee
    {
        public string ContractorName { get; set; }
        
        public override void Print()
        {
            Console.WriteLine("From ParttimeEmployee Class - Employee id ={0}, firstName={1}, lastName={2}, ContractorName={3}", Id, FirstName, LastName, ContractorName);
        }
    }
}
