using Ex_fixacao_enum.Entities;
using Ex_fixacao_enum.Entities.Enums;
using System;

namespace Ex_fixacao_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("Email: ");
            String email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birth);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime moment = DateTime.Now;
            Order order = new Order(moment, status, client);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<= n; i++ )
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                String nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                Double priceProduct = Double.Parse(Console.ReadLine());
                Console.Write("Product quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, priceProduct);
                OrderItem item = new OrderItem(quantityProduct, priceProduct, product);
                order.addItem(item);
                
            }

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order); 

        }
    }
}
