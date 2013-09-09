using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OrderManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            var item1 = new OrderItem(){ Id=101, Name="Pen", Units=5, UnitCost=12};
            var item2 = new OrderItem(){ Id=102, Name="Pencil", Units=10, UnitCost=11};
            var item3 = new OrderItem(){ Id=103, Name="Marker", Units=15, UnitCost=20};
            var item4 = new OrderItem(){ Id=104, Name="Pen Drive", Units=5, UnitCost=200};

            order.AddItem(item1);
            order.AddItem(item2);
            order.AddItem(item3);
            order.AddItem(item4);

            Console.WriteLine("Your order value is {0}",order.GetTotal());
            order.Print(Console.Out);

            var writer = new StreamWriter("order.txt");
            order.Print(writer);
            writer.Close();
            Console.ReadLine();
        }
    }

    public class Order
    {
        private ArrayList list = new ArrayList();
        public void AddItem(OrderItem item)
        {
            list.Add(item);
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var item in list)
            {
                var orderItem = (OrderItem) item;
                total += orderItem.Units*orderItem.UnitCost;
            }
            return total;
        }

        public void Print(TextWriter tw)
        {
            foreach (var item in list)
            {
                tw.WriteLine(item);
            }
            tw.WriteLine("Total = {0}", this.GetTotal());
        }
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Units { get; set; }
        public decimal UnitCost { get; set; }
        public override string ToString()
        {
            return string.Format("{0}\t {1} \t{2} \t{3} \t{4}", this.Id, this.Name, this.Units, this.UnitCost,
                                 this.Units*this.UnitCost);
        }
    }


}
