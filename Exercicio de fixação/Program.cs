using System;
using Exercicio_de_fixação.Entities;
using Exercicio_de_fixação.Entities.Enum;
using System.Globalization; 

namespace Exercicio_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse < OrderStatus >(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine();
            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            
           

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nome = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantidade = int.Parse(Console
                    .ReadLine());

                Product product = new Product(name, price);
                OrderItem orderItem = new OrderItem(quantidade,price,product);

                order.AddItem(orderItem);
            }

            Console.WriteLine("-----------");
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        
        }
    }
}
