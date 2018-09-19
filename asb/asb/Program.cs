using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asb
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            Console.WriteLine("enter a number to find even or odd");
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("your number is even");
            }
            else
            {
                Console.WriteLine("your number is odd");
            }



            int a, b;
            Console.WriteLine("enter a number nd i'll find bigg or small no.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your 2nd number");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                 Console.Write("your  greater is {0}", a);
            }
            else
            {
                  Console.Write("your  greater is {0}",b);
            }
           // Console.ReadLine();



            int g, j=7;
           Console.WriteLine("\nguess my number");
               g= int.Parse(Console.ReadLine());
            
           if(g==j)
            {
                Console.WriteLine("Right");
            }
            else
            {
                Console.WriteLine("wrong");
            }



                
                
            int m;
            Console.WriteLine("enter your marks");
            m= int.Parse(Console.ReadLine());
            if(m<=39)
            {
                Console.WriteLine("you are lucky we'ill give you one more chance");
            }
            else if (m<= 49)
            {
                Console.WriteLine("your grade is=D");
             
            }
            else if (m<= 59)
            {
                Console.WriteLine("your grade is=C");
            }
            else if (m<= 69)
            {
                Console.WriteLine("your grade is=B");
            }
            else if (m<= 79)
            {
                Console.WriteLine("your grade is=B+");
            }
            else if (m<= 89)
            {
                Console.WriteLine("your grade is=A");
            }
            else if (m<= 99)
            {
                Console.WriteLine("your grade is=A+");
            }
            else
            {
                Console.WriteLine("itz cheating case");
                   
            }
            int p, r;
            Console.WriteLine("enter a pin");
            p = int.Parse(Console.ReadLine());
            if (p <= 10000 || p>9999) 
            {
                Console.WriteLine("re-enter your pin");
                r = int.Parse(Console.ReadLine());
                if (r==p)
                {
                    Console.WriteLine("your pin is comfirmed ThANK YOU");
                }
                else if (r != p)
                {
                    Console.WriteLine("error");
                }
               
            }
            else{
                Console.WriteLine("error");

            }




            Console.ReadLine();
        }
    }
}
