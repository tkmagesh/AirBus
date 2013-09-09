using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order(1000);
            
            //order.OnMaxOrderValueReached += NotifyMaxOrderValueReached;

            order.AddLineItem(new LineItem(){Id =1,Name = "P1", UnitCost = 100, Units = 5});
            Console.WriteLine(order.OrderValue);
            order.AddLineItem(new LineItem() { Id = 1, Name = "P1", UnitCost = 100, Units = 5 });
            Console.ReadLine();
        }

        public static void NotifyMaxOrderValueReached()
        {
            Console.WriteLine("maximum order value reached");
        }
    }

    public delegate void MaxOrderValueReachedDelegate();

    class Order
    {
        private readonly decimal _maxOrderValue;
        
        public MaxOrderValueReachedDelegate OnMaxOrderValueReached { get; set; }

        public Order(decimal maxOrderValue)
        {
            _maxOrderValue = maxOrderValue;
        }

        private ArrayList lineItems = new ArrayList();
 
        public void AddLineItem(LineItem lineItem)
        {
            lineItems.Add(lineItem);
            if ((this.OrderValue >= _maxOrderValue) && OnMaxOrderValueReached != null)
                OnMaxOrderValueReached();
        }

        public decimal OrderValue
        {
            get { 
                var result = 0m;
                foreach (var item in lineItems)
                {
                    var lineItem = (LineItem) item;
                    result += lineItem.Units*lineItem.UnitCost;
                }
                return result;
            }
        }
    }

    public class LineItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitCost { get; set; }
        public int Units { get; set; }
    }
}
