using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("loop and if else");

            for (int i = 75; i >= 47; i--)
            {
                if (i % 2 != 0) 
                {
                    Console.WriteLine($"{i}");
                }
               
            }
            string a, b;
            Console.WriteLine("enter anything");
            a = Console.ReadLine();
            Console.WriteLine("enter a value for repeat it");
            b = Console.ReadLine();
            for(int i=a; a<=b ;i++)
            {
                Console.WriteLine($"{a}");
                }

            Console.ReadLine();



            Console.ReadLine();
        }
    
    }
}
