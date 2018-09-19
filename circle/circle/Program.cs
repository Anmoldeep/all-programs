using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" write the radius of your circle  ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"your radius{radius} circumfrence {circum(radius)} and area {are(radius)}");
            //Console.WriteLine("Your Radius {0:0} Your circumfrence {1:0} your area {1:1}", radius, circum(radius),are(radius) );
            Console.ReadLine();

        }
        public static double circum( double radius)
        {
            double pi = Math.PI;
            double circumference = 2 * pi * radius;
            return circumference;
        }
        public static double are( double radius)
        {
            double pi = Math.PI;
            double area = 2 * pi * radius * radius;
            return area;
        }
    }
}
