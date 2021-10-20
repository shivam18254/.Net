using System;

namespace switch_one
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your pizza: ");
            string pizza = Console.ReadLine();

            switch (pizza)
            {
                case "farm house":
                    Console.WriteLine("you have selected farm house pizza");
                    break;
                case "single chezz":
                    Console.WriteLine("you have selected single cheez");
                    break;
                case "double chezz":
                    Console.WriteLine("you have selected double chezz");
                    break;
                case "fajeeta":
                    Console.WriteLine("you have selected fajeeta pizza");
                    break;
                case "vegitable":
                    Console.WriteLine("enter your vegitable");
                    string veg = Console.ReadLine();
                    switch(veg)
                    {
                        case "onions":
                            Console.WriteLine("you have  selected onions in your pizza");
                            break;
                        case "masroom":
                            Console.WriteLine("you have  selected masroom in your pizza");
                            break;
                        case "olives":
                            Console.WriteLine("you have  selected olives in your pizza");
                            break;
                        case "green chilly":
                            Console.WriteLine("you have  selected green chilly in your pizza");
                            break;
                            break;
                        default:
                            Console.WriteLine("sorry!! not avelable!!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("sorry!! not avelable!!");
                    break;
            }
        }

    }
}

