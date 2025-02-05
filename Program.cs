using System;

namespace OrderProcessing
{
    class Program
    {
        static void Main()
        {
            Order order = new Order();

            while (true)
            {
                Console.WriteLine("\nOrder Management System");
                Console.WriteLine("1. Process Order");
                Console.WriteLine("2. Cancel Order");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        order.Process();
                        break;
                    case "2":
                        order.Cancel();
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}
