using ExercHeranPolimorf.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercHeranPolimorf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?: ");
                char typeOfProduct = char.Parse(Console.ReadLine());

                if (typeOfProduct == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }

                if (typeOfProduct == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacute date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }

                if (typeOfProduct == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customsFee));
                }

                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product produtc in list)
            {
                Console.WriteLine(produtc.PriceTag());
            }
        }
    }
}
