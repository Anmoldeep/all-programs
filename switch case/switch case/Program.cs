using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            string pet;
            Console.WriteLine("enter a pet name");
            pet = Console.ReadLine();


            switch (pet)
            {
                case "dog":
                    Console.WriteLine("yes");
                    break;
                case "cat":
                    Console.WriteLine("no");
                    break;
                default:

                    Console.WriteLine($"not in prgrm({pet})");

                    break;

            }
            string fruit;
            Console.WriteLine("enter a fruit nam to knw cost");
            fruit = Console.ReadLine();
            switch (fruit)
            {
                case "apples":
                    Console.WriteLine($"({fruit})1.25 per kg");
                    break;

                case "bananas":
                    Console.WriteLine($"({fruit})3.15 per kg");
                    break;

                case "kiwifruit":
                    Console.WriteLine($"({fruit})4.65 per kg");
                    break;

                case "orange":
                    Console.WriteLine($"({fruit})2.75 per kg");
                    break;
                default:
                    Console.WriteLine($"({fruit}) not in prgrm");
                    break;
                    
            }
            string a, b, c, d;
            Console.WriteLine("enter a value");
            a = Console.ReadLine();

            Console.WriteLine("enter a value");
            b= Console.ReadLine();

            Console.WriteLine("enter a symbol");
            c = Console.ReadLine();
            switch (c)
            {
                case "+":
                    d = a + b;
                    Console.WriteLine($"({d})");
                    break;
                case "-":

                    d = a + b;
                    Console.WriteLine($"({d})");
                    break;

            }

            Console.ReadLine();
        }
    }
}

