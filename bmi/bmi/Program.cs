using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your weight in kg ");
            double w = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your height in m");
            double h = int.Parse(Console.ReadLine());
            double bmiResult = bmi(w, h);
            Console.WriteLine($"your bmi is ={bmi( w , h)}");
            Console.WriteLine($" {categories(bmiResult)}");


            Console.ReadLine();
           
            

        }
        static public double bmi(double w, double h)
        {
            double bmi = w / (h * h);
            
            return bmi;
        }
        public static string categories( double bmi)
        {
            string bmic = "";
          
            if(bmi <18.5)
            {
                bmic = "your bmi is underweight";
            }
            else if (18.5 <= bmi && bmi < 25)
            {
                Console.WriteLine("your bmi is noprmalweight");
            
            }
            else if (25<=bmi && bmi <30)
            {
                Console.WriteLine("your bmi is overweight");
            }
            else 
            {
                Console.WriteLine("your bmi is obese");
            }
            return bmic;
        }
            
    }
}
