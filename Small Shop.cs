using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            
            switch (product)
            {
                case "coffee":
                    switch (town)
                    {
                        case "Sofia":
                            Console.WriteLine(0.5*quantity);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(0.4*quantity);
                            break;
                        case "Varna":
                            Console.WriteLine(0.45*quantity);
                            break;
                    }
                    break;
                case "water":
                    switch (town)
                    {
                        case "Sofia":
                            Console.WriteLine(0.8 * quantity);
                            break;
                        case "Plovdiv":
                        case "Varna":
                            Console.WriteLine(0.7 * quantity);
                            break;
                            Console.WriteLine(0.45 * quantity);
                            break;
                    }
                    break;
                case "beer":
                    switch (town)
                    {
                        case "Sofia":
                            Console.WriteLine(1.2 * quantity);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(1.15 * quantity);
                            break;
                        case "Varna":
                            Console.WriteLine(1.1 * quantity);
                            break;
                    }
                    break;
                case "sweets":
                    switch (town)
                    {
                        case "Sofia":
                            Console.WriteLine(1.45 * quantity);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(1.3 * quantity);
                            break;
                        case "Varna":
                            Console.WriteLine(1.35 * quantity);
                            break;
                    }
                    break;
                case "peanuts":
                    switch (town)
                    {
                        case "Sofia":
                            Console.WriteLine(1.6 * quantity);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(1.5 * quantity);
                            break;
                        case "Varna":
                            Console.WriteLine(1.55 * quantity);
                            break;
                    }
                    break;
            }
        }
    }
}
