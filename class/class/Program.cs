using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a m iles");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine($"your {miles} changed {changeR(miles)}");
            Console.ReadLine();
        }
        public static double changeR(double miles)
        {
            double rslt = miles / 0.62137;
            return rslt;
        }
      
        
       
        

    }
}
