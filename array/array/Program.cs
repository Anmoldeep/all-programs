using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for (int i = 0; i< num.Length; i++)
            {
                Console.Write($"enter a number{i + 1}:");
                num[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

        }
    }
}
