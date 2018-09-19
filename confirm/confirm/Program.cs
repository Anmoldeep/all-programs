using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confirm
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            Console.WriteLine("task A type 1");
            menu = Console.ReadLine();
            if (menu=="1")
            {
                call();
            }

            int p, r;
            Console.WriteLine("enter a pin");
            p = int.Parse(Console.ReadLine());
            if ((p<1000 || p>9999))
            {
                
                
        
                    
                    Console.WriteLine("error");
                   
                    
                

            }
            else
            {
                
                Console.WriteLine(" re-enter your pin");
                r = int.Parse(Console.ReadLine());
                if (r == p)
                {
                    Console.WriteLine("your pin is comfirmed ThANK YOU");
                }
                if (r != p)
                {
                    Console.WriteLine("error");
                }

            }

            string a, b, c;
            Console.WriteLine("enter a word");
            a = Console.ReadLine();
            Console.WriteLine("enter second word");
            b = Console.ReadLine();
            Console.WriteLine("enter your third word");
            c = Console.ReadLine();
            if(b!="a" && b!="e" && b != "i" && b != "o" && b != "u")
            {
                Console.WriteLine("its not pallindrome");
            }
            else if(a!=c)
            {
                Console.WriteLine("its not pallindrome");
            
            }
            else
            {
                Console.WriteLine("pallindrome");
            }
         
            
              
        
            Console.ReadLine();

        }
        public static void call()
        {
            Console.WriteLine("hi");
            Console.ReadLine();
        }
    }
}



