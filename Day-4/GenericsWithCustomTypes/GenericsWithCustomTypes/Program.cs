using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsWithCustomTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();
            products.Add(new Product() { Id = 21, Name = "Pen", Unitcost = 110, Units = 25});
            products.Add(new Product() { Id = 11, Name = "Hen", Unitcost = 120, Units = 22 });
            products.Add(new Product() { Id = 10, Name = "Ken", Unitcost = 102, Units = 28 }); 
            products.Add(new Product() { Id = 1, Name = "Gen", Unitcost = 132, Units = 21 });
            products.Add(new Product() { Id = 5, Name = "Ten", Unitcost = 143, Units = 20 });
            products.Add(new Product() { Id = 7, Name = "Len", Unitcost = 111, Units = 26 });
            Console.WriteLine("Initial List");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();
            Console.WriteLine("After sorting by Id");
            products.Sort(new ProductComparerById());
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
            Console.WriteLine("After sorting by UnitCost");
            products.Sort(new ProductComparerByUnitCost());
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
            Console.WriteLine("After sorting by Units (using delegate)");
            products.Sort(ProductComparisonByUnits);
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }

        public static int ProductComparisonByUnits(Product x, Product y)
        {
            if (x.Units < y.Units) return -1;
            if (x.Units > y.Units) return 1;
            return 0;
        }

    }

    class ProductComparerById : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x.Id < y.Id) return -1;
            if (x.Id > y.Id) return 1;
            return 0;
        }
    }

    class ProductComparerByUnitCost : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x.Unitcost < y.Unitcost) return -1;
            if (x.Unitcost > y.Unitcost) return 1;
            return 0;
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Unitcost { get; set; }
        public int Units { get; set; }
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", Id, Name, Unitcost, Units);
        }
    }
}
