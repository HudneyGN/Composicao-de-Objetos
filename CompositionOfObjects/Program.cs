using System;
using System.Globalization;
using CompositionOfObjects.Entities;
using CompositionOfObjects.Entities.Enums;

namespace CompositionOfObjects {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            //string txt = OrderStatus.Processing.ToString();
            Console.WriteLine();
            Client client = new Client(name, email, birth);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++) {
                Console.WriteLine("Enter #1 item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("Order Sumary: ");
            Console.WriteLine(order);
        }
    }
}