﻿using System;
using MoreAboutCompositionAndEnum.Entities.Enums;
using MoreAboutCompositionAndEnum.Entities;
using System.Globalization;

namespace MoreAboutCompositionAndEnum
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
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many item to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(qtd, product);
                order.AddItem(item);
            }
            Console.WriteLine(order);
            
        }
    }
}
