using Ex_her_pol.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex_her_pol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)?: ");
                Char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (c)
                {
                    case 'c':

                        products.Add(new Product(name, price));
                        break;

                    case 'i':
                        Console.Write("Custom fee: ");
                        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customFee));
                        break;

                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                }
            }

            Console.WriteLine("PRICE TAGS: ");

            foreach(Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
