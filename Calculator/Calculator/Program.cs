using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           // char add, sub, mull, div;
            int a, b, c, d, e, f;
            Console.WriteLine("give value for a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("give value for b=");
            b = int.Parse(Console.ReadLine());
         //   if (mull)
            c = a + b;
            d = a - b;
            e = a * b;
            f = a % b;
            Console.WriteLine("*Add= {0}", c);
            Console.WriteLine("*Sub= {0}", d);
            Console.WriteLine("*mulltiple= {0}", e);
            Console.WriteLine("*divide= {0}", f);
            Console.ReadLine();

        }
    }
}
