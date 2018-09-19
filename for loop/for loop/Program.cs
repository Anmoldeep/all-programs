using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter avalue");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter avalue");
            b= int.Parse(Console.ReadLine());


            Console.WriteLine("n\t10*n\t\t100*n\t\t1000*n");
            Console.WriteLine("-\t----\t\t----\t\t------");


            Console.WriteLine(">>>>for<<<<<");

            for ( int i=a;i<=b;i++)
            {
                Console.WriteLine($"{i}\t{i*10}\t\t{i*100}{i}\t\t{i*1000}");
                
            }
            Console.WriteLine(">>>>while<<<<<");
            int j = a;
            while(j<=b)
            {
                Console.WriteLine($"{j}\t{j * 10}\t\t{j * 100}\t\t{j * 1000}");
                j++;
            }
            Console.WriteLine(">>>>do while<<<<<");

            int k = a;
            do
            {
                Console.WriteLine($"{k}\t{k * 10}\t\t{k * 100}\t\t{k * 1000}");
                k++;
            } while (k <= b);

            int f, l;
            Console.WriteLine("enter 1st value");
            f = int.Parse(Console.ReadLine());

            Console.WriteLine("enter last value");
            l = int.Parse(Console.ReadLine());


            Console.WriteLine(">>>>for<<<<<");
            for (int i=1; i<=10;i++)
            {

                Console.WriteLine($"{f}*{i}={i*7}");
               
            }
            Console.WriteLine(">>>while<<<<<");
            int e=f;
            while (e<=l)
            {
                Console.WriteLine($"{e}*7={e*7}");
                e++;


            }


            Console.WriteLine(">>>>do while<<<<<");
            int w = f;
            do
            {
                Console.WriteLine($"{w}*7={w * 7}");

               w++;
            } while (w <=l);
            Console.WriteLine(">>>>>for<<<<<");

            int square, cube, r;
            Console.WriteLine("enter a number");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("\t number\tsquare\tcube");

            for (int i=1;i<=r;i++)
            {
                square = i * i;
                cube = square * i;
                Console.WriteLine($"\t{i}\t{square}\t{cube}");
            }




            Console.ReadLine();






        }
    }
}
