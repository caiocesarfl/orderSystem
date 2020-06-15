using System;
using OrderSystem.Entities;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);

            Order order = new Order(client);

            Console.WriteLine("A-Adicionar Mais Itens");
            char opcao = Char.Parse(Console.ReadLine());
            
            while (opcao == 'A')
            {
                Console.WriteLine("Product Name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Unity Price: ");
                double unityPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, unityPrice);
                OrderItem orderItem = new OrderItem(quantity, product);

                order.AddOrderItem(orderItem);

                Console.WriteLine("A-Adicionar Mais Itens");
                opcao = Char.Parse(Console.ReadLine());
               
            }

            Console.WriteLine(order.ToString());

        }
    }
}
